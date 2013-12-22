using System;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;


namespace Emailer
{
    public partial class formEmailer : Form
    {
        public formEmailer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");

            //assignTmpValues();
        }

        private void assignTmpValues()
        {
            txtSubj.Text = "Компания {1} сообщает о {2}";

            richTxtEMailBody.Text = "Хочеш {0}, Хочеш {1}, Хочеш {2}, Хочеш {3}, Хочеш {4}, Хочеш {5}, Хочеш {6}, Хочеш {7}, Хочеш {8}, Хочеш {9} и это, пока, все!";

            txtSenderEmail.Text = "asmbank@bk.ru";
            txtEmailTo.Text = "{0}"; //"asminfo@bk.ru";

            txtBCCEmail.Text = "omaksiuta@luxoft.com";

            txtSMTP.Text = "smtp.bk.ru";
            txtEmailLogin.Text = "asmbank@bk.ru";
            txtEmailPassword.Text = "Microsoft)1";

            txtFileWithAutoValues.Text = "D:\\AlexS\\Projects\\Emailer\\Emailer\\input.txt";

        }

        void checkInputsAndSendEmails()
        {
            //перезагружаем список
            reloadInputFile(false);

            //Активируем закладку
            tabControl1.SelectedTab = tabControl1.TabPages[2];
            tabControl1.Refresh();


            string msgFrom = txtSenderEmail.Text.Trim();
            string msgTo = txtEmailTo.Text;
            string msgSubject = txtSubj.Text.Trim();
            string msgBody = richTxtEMailBody.Text.Trim();
            bool msgIsBodyHtml = chkboxEmailFormat.Checked;
            string msgPriority = dllPrior.SelectedItem.ToString().Trim();
            string msgAttachPath = txtAttach1.Text.Trim();
            string msgCC = null;
            string msgBcc = txtBCCEmail.Text.Trim();
            string setSmtpHost = txtSMTP.Text.Trim();
            string setSmtpPort = txtSmtpPort.Text.Trim();
            string setLoginEmail = txtEmailLogin.Text.Trim();
            string setPassword = txtEmailPassword.Text.Trim();

            string newMsgFrom;
            string newMsgTo;
            string newMsgSubject;
            string newMsgBody;
            string newMsgBcc;


            StringBuilder err = new StringBuilder();

            #region Проверка настроек и собрание ошибок в err
            if (txtFileWithAutoValues.Text.Trim().Length == 0)
            {
                err.AppendLine("Поле 'Файл с Aвтоподстановками' - пустое, отправка писем невозможна!");
                tabControl1.SelectedTab = tabControl1.TabPages[2];
            }

            if (lbxReport.Items.Count < 1)
            {
                err.AppendLine("Список подстановок не загружен!, отправка писем отменена!");
                tabControl1.SelectedTab = tabControl1.TabPages[2];
            }

            if (msgTo.Trim().Length == 0)
            {
                err.AppendLine("Поле 'Кому Email' - пустое, отправка писем невозможна!");
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }

            if (msgFrom.Trim().Length == 0)
            {
                err.AppendLine("Поле 'От Email' - пустое, отправка писем невозможна!");
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }

            if (msgSubject.Trim().Length == 0)
            {
                err.AppendLine("Поле 'Тема Письма' - пустое, отправка писем невозможна!");
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }

            if (setSmtpHost.Length == 0)
            {
                err.AppendLine("Поле 'SMTP Host' - пустое, отправка писем невозможна!");
                tabControl1.SelectedTab = tabControl1.TabPages[1];
            }

            if (setLoginEmail.Length == 0)
            {
                err.AppendLine("Поле 'Email Логин' - пустое, отправка писем невозможна!");
                tabControl1.SelectedTab = tabControl1.TabPages[1];
            }

            if (setPassword.Length == 0)
            {
                err.AppendLine("Поле 'Email Пароль' - пустое, отправка писем невозможна!");
                tabControl1.SelectedTab = tabControl1.TabPages[1];
            }

            #endregion
            if (err.Length > 0)
            {
                MessageBox.Show(err.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tabControl1.Refresh();
                return;
            }


            #region Sending Email to All users
            DialogResult result = MessageBox.Show(
                "Вы готовы отправить, это письмо, всем пользователям?"
                , "Проверка!"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                #region Sending Email To All Users, with change for MsgTo

                int pbMax = lbxReport.Items.Count - 1;
                pb.Minimum = 0;
                pb.Maximum = pbMax;

                string rowLine;
                string[] rowValues;

                for (int i = 0; i < lbxReport.Items.Count; i++)
                {
                    pb.Value = i;
                    pb.Refresh();

                    rowLine = lbxReport.Items[i].ToString().Trim();
                    if (rowLine.Length == 0)
                    {
                        lbxReport.Items[i] = "Ошибка чтения! \t Пустая строка >>>>>>> \t" + rowLine;

                    }
                    else
                    {
                        //Парсим строку и отправляем письмо
                        //rowValues = rowLine.Split('|');
                        char separator = Convert.ToChar(txtSeparator.Text.Trim());
                        rowValues = rowLine.Split(separator);

                        //Производим замену значений в полях

                        newMsgFrom = replaceAutoTextsWithValues(msgFrom, rowValues);
                        newMsgTo = replaceAutoTextsWithValues(msgTo, rowValues);
                        newMsgSubject = replaceAutoTextsWithValues(msgSubject, rowValues);
                        newMsgBody = replaceAutoTextsWithValues(msgBody, rowValues);
                        newMsgBcc = replaceAutoTextsWithValues(msgBcc, rowValues);

                        #region Проверка автозамены
                        if (newMsgFrom.Contains("{") && newMsgFrom.Contains("}") || newMsgFrom == null)
                        {
                            err.AppendLine("Поле 'От Email' - не все заменилось, отправка отменена!");

                        }
                        if (newMsgTo.Contains("{") && newMsgTo.Contains("}") || newMsgTo == null)
                        {
                            err.AppendLine("Поле 'Кому Email' - не все заменилось, отправка отменена!");

                        }
                        if (newMsgSubject.Contains("{") && newMsgSubject.Contains("}") || newMsgSubject == null)
                        {
                            err.AppendLine("Поле 'Тема Письма' - не все заменилось, отправка отменена!");

                        }
                        if (newMsgBody.Contains("{") && newMsgBody.Contains("}") || newMsgBody == null)
                        {
                            err.AppendLine("Поле 'Тело Письма' - не все заменилось, отправка отменена!");

                        }
                        if (newMsgBcc.Contains("{") && newMsgBcc.Contains("}"))
                        {
                            err.AppendLine("Поле 'Скрытая Копия' - не все заменилось, отправка отменена!");

                        }


                        #endregion
                        if (err.Length > 0)
                        {
                            lbxReport.Items[i] = "Ошибка отправки! \t" + err.ToString().Replace("\n", ";") + " >>>>>>> \t" + rowLine;
                            err.Clear();
                        }
                        else
                        {

                            string sendEmailResult = Mailer.SendEmail(newMsgFrom, newMsgTo, newMsgSubject, newMsgBody, msgIsBodyHtml, msgPriority, msgCC, newMsgBcc, msgAttachPath, setSmtpHost, setSmtpPort, setLoginEmail, setPassword);

                            if (sendEmailResult != null)
                            {
                                lbxReport.Items[i] = "Ошибка отправки! \t" + sendEmailResult + " >>>>>>> \t" + rowLine;
                            }
                            else
                            {
                                lbxReport.Items[i] = "Отправлено! \t \t" + rowLine;
                                lbxReport.SelectedIndex = i;
                            }
                        }
                    }
                }

                MessageBox.Show("Отправка писем, всем пользователям, завершена!", "Инфо!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                #endregion
            }
            else
            {
                MessageBox.Show("Отправка писем отменена!", "Инфо!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            #endregion
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {

            checkInputsAndSendEmails();



            ////Отправляем письма
            //ThreadStart sendGoodEmail = new ThreadStart(checkInputsAndSendEmails);
            //Thread thread = new Thread(sendGoodEmail);
            //thread.Start();

        }




        /// <summary>
        /// Replace fro {0} to {9} val;ues
        /// </summary>
        /// <param name="text"></param>
        /// <param name="newValues"></param>
        /// <returns></returns>
        string replaceAutoTextsWithValues(string text, string[] newValues)
        {
            //{0}
            string keyPattern;
            try
            {
                int arrindex = 0;
                foreach (string key in newValues)
                {
                    keyPattern = String.Concat("{", arrindex, "}").Trim();

                    if (text.Trim().Contains(keyPattern))
                    {
                        text = text.Replace(keyPattern, newValues[arrindex].Trim());
                    }
                    arrindex = arrindex + 1;
                }

                return text;
            }
            catch
            {
                return null;
            }
        }



        #region files selections
        private void selectFilePathToTextBox(TextBox txt)
        {

            OpenFileDialog OpenAnswerFile = new OpenFileDialog();
            OpenAnswerFile.Title = "Выбирите файл";
            OpenAnswerFile.Multiselect.Equals(false);
            OpenAnswerFile.DefaultExt = null;

            //// check if OK was pressed.
            if (OpenAnswerFile.ShowDialog() == DialogResult.OK)
            {



                string filetoread = OpenAnswerFile.FileName;
                StreamReader filestream = File.OpenText(filetoread);
                string readcontents = filestream.ReadToEnd();
                filestream.Dispose();
                filestream.Close();

                txt.Text = filetoread;




            }

        }

        private void btnSelectAttach_Click(object sender, EventArgs e)
        {
            selectFilePathToTextBox(txtAttach1);

        }

        void reloadInputFile(bool reselectFile = true)
        {
            if (lbxReport.Items.Count == 0 && reselectFile == false)
            {
                return;
            }


            if (lbxReport.Items.Count > 0)
            {
                lbxReport.Items.Clear();
                lbxReport.Refresh();
            }



            if (reselectFile == true)
            {
                selectFilePathToTextBox(txtFileWithAutoValues);
            }

            string fileToRead = txtFileWithAutoValues.Text.Trim();
            if (fileToRead.Length > 0)
            {
                using (StreamReader sr = new StreamReader(fileToRead))
                {
                    if (lbxReport.Items.Count > 0)
                    {
                        lbxReport.Items.Clear();
                        lbxReport.Refresh();
                    }


                    string rowFromTxt;
                    int lineIndex = 0;

                    while ((rowFromTxt = sr.ReadLine()) != null)
                    {
                        lbxReport.Items.Insert(lineIndex, rowFromTxt);

                        lineIndex = lineIndex + 1;
                    }
                }
            }

        }

        private void btnLoadFileWithAutoValues_Click(object sender, EventArgs e)
        {
            reloadInputFile();
        }

        #endregion

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            DialogResult msgBoxResult = MessageBox.Show("Вы уверены что хотите очистить, все поля?", "Проверка!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgBoxResult == DialogResult.Yes)
            {
                txtEmailTo.Text = null;
                txtBCCEmail.Text = null;
                richTxtEMailBody.Text = null;
                txtSenderEmail.Text = null;
                txtBCCEmail.Text = null;
                txtSubj.Text = null;
                txtAttach1.Text = null;

            }


        }

        private void btnExportToTxt_Click(object sender, EventArgs e)
        {
            string dt = DateTime.Now.ToString().Replace(":", "-").Replace("/", "-").Replace(" ", "_").Replace(".", "_") + DateTime.Now.Millisecond;
            exportCheckedListBoxToTextFile("EmailReport_" + dt + ".txt", lbxReport);
        }

        void exportCheckedListBoxToTextFile(string fileName, ListBox clb)
        {
            try
            {
                // Open output file 
                StreamWriter sWriter = new StreamWriter(fileName);

                //sWriter.WriteLine("Files to validate: " + lblCountFilesInFolder.Text);
                sWriter.WriteLine();

                // Write records 

                for (int i = 0; i < clb.Items.Count; i++)
                {
                    sWriter.Write(clb.Items[i].ToString());
                    sWriter.WriteLine();

                }
                sWriter.Close();


                //Process.Start("notepad.exe", fileName);
                Process pr = new Process();
                pr.StartInfo.FileName = fileName;
                pr.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                pr.Start();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void lbxReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }


    }
}
