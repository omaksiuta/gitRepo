namespace Emailer
{
    partial class formEmailer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblNote = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailTo = new System.Windows.Forms.TextBox();
            this.dllPrior = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenderEmail = new System.Windows.Forms.TextBox();
            this.txtBCCEmail = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnSelectAttach = new System.Windows.Forms.Button();
            this.txtAttach1 = new System.Windows.Forms.TextBox();
            this.txtSubj = new System.Windows.Forms.TextBox();
            this.richTxtEMailBody = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSmtpPort = new System.Windows.Forms.TextBox();
            this.lblSMTP = new System.Windows.Forms.Label();
            this.txtSMTP = new System.Windows.Forms.TextBox();
            this.chkBoxUTF8 = new System.Windows.Forms.CheckBox();
            this.chkboxEmailFormat = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnExportToTxt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLoadFileWithAutoValues = new System.Windows.Forms.Button();
            this.txtFileWithAutoValues = new System.Windows.Forms.TextBox();
            this.lbxReport = new System.Windows.Forms.ListBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(682, 469);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.lblNote);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtEmailTo);
            this.tabPage1.Controls.Add(this.dllPrior);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnClearFields);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSenderEmail);
            this.tabPage1.Controls.Add(this.txtBCCEmail);
            this.tabPage1.Controls.Add(this.btnSendEmail);
            this.tabPage1.Controls.Add(this.btnSelectAttach);
            this.tabPage1.Controls.Add(this.txtAttach1);
            this.tabPage1.Controls.Add(this.txtSubj);
            this.tabPage1.Controls.Add(this.richTxtEMailBody);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(674, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Письмо";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblNote.Location = new System.Drawing.Point(89, 16);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(413, 17);
            this.lblNote.TabIndex = 22;
            this.lblNote.Text = "Максимальное количество переменных = 10 >>> от {0} до {9}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(42, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Кому Email:";
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Location = new System.Drawing.Point(127, 45);
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(527, 22);
            this.txtEmailTo.TabIndex = 20;
            this.txtEmailTo.Text = "{0}";
            // 
            // dllPrior
            // 
            this.dllPrior.FormattingEnabled = true;
            this.dllPrior.Items.AddRange(new object[] {
            "Normal",
            "Low",
            "High"});
            this.dllPrior.Location = new System.Drawing.Point(103, 407);
            this.dllPrior.Name = "dllPrior";
            this.dllPrior.Size = new System.Drawing.Size(72, 24);
            this.dllPrior.TabIndex = 19;
            this.dllPrior.Text = "Normal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(13, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Приоритет:";
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.Maroon;
            this.btnClearFields.ForeColor = System.Drawing.Color.White;
            this.btnClearFields.Location = new System.Drawing.Point(518, 6);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(137, 36);
            this.btnClearFields.TabIndex = 15;
            this.btnClearFields.Text = "Очистить Форму";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(13, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Вложить Файл:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(78, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Тема:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(56, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "От Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(11, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Скрытая Копия:";
            // 
            // txtSenderEmail
            // 
            this.txtSenderEmail.Location = new System.Drawing.Point(128, 73);
            this.txtSenderEmail.Name = "txtSenderEmail";
            this.txtSenderEmail.Size = new System.Drawing.Size(527, 22);
            this.txtSenderEmail.TabIndex = 10;
            // 
            // txtBCCEmail
            // 
            this.txtBCCEmail.Location = new System.Drawing.Point(128, 103);
            this.txtBCCEmail.Name = "txtBCCEmail";
            this.txtBCCEmail.Size = new System.Drawing.Size(526, 22);
            this.txtBCCEmail.TabIndex = 9;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.Maroon;
            this.btnSendEmail.Location = new System.Drawing.Point(500, 402);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(154, 28);
            this.btnSendEmail.TabIndex = 8;
            this.btnSendEmail.Text = "Отправить Писмо!";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnSelectAttach
            // 
            this.btnSelectAttach.ForeColor = System.Drawing.Color.Maroon;
            this.btnSelectAttach.Location = new System.Drawing.Point(579, 159);
            this.btnSelectAttach.Name = "btnSelectAttach";
            this.btnSelectAttach.Size = new System.Drawing.Size(75, 28);
            this.btnSelectAttach.TabIndex = 7;
            this.btnSelectAttach.Text = "Выбрать";
            this.btnSelectAttach.UseVisualStyleBackColor = true;
            this.btnSelectAttach.Click += new System.EventHandler(this.btnSelectAttach_Click);
            // 
            // txtAttach1
            // 
            this.txtAttach1.Enabled = false;
            this.txtAttach1.Location = new System.Drawing.Point(128, 162);
            this.txtAttach1.Name = "txtAttach1";
            this.txtAttach1.Size = new System.Drawing.Size(444, 22);
            this.txtAttach1.TabIndex = 6;
            // 
            // txtSubj
            // 
            this.txtSubj.Location = new System.Drawing.Point(128, 131);
            this.txtSubj.Name = "txtSubj";
            this.txtSubj.Size = new System.Drawing.Size(526, 22);
            this.txtSubj.TabIndex = 5;
            // 
            // richTxtEMailBody
            // 
            this.richTxtEMailBody.Location = new System.Drawing.Point(17, 193);
            this.richTxtEMailBody.Name = "richTxtEMailBody";
            this.richTxtEMailBody.Size = new System.Drawing.Size(637, 205);
            this.richTxtEMailBody.TabIndex = 4;
            this.richTxtEMailBody.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtSeparator);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtEmailPassword);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtEmailLogin);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtSmtpPort);
            this.tabPage2.Controls.Add(this.lblSMTP);
            this.tabPage2.Controls.Add(this.txtSMTP);
            this.tabPage2.Controls.Add(this.chkBoxUTF8);
            this.tabPage2.Controls.Add(this.chkboxEmailFormat);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(674, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(147, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(275, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Тут нельзя использовать автозначения!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Разделитель:";
            // 
            // txtSeparator
            // 
            this.txtSeparator.Location = new System.Drawing.Point(110, 257);
            this.txtSeparator.MaxLength = 1;
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.ReadOnly = true;
            this.txtSeparator.Size = new System.Drawing.Size(51, 22);
            this.txtSeparator.TabIndex = 12;
            this.txtSeparator.Text = "|";
            this.txtSeparator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Email Пароль";
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.Location = new System.Drawing.Point(119, 193);
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.Size = new System.Drawing.Size(214, 22);
            this.txtEmailPassword.TabIndex = 10;
            this.txtEmailPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email Логин:";
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Location = new System.Drawing.Point(119, 165);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(214, 22);
            this.txtEmailLogin.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "SMTP Port:";
            // 
            // txtSmtpPort
            // 
            this.txtSmtpPort.Location = new System.Drawing.Point(421, 138);
            this.txtSmtpPort.Name = "txtSmtpPort";
            this.txtSmtpPort.Size = new System.Drawing.Size(51, 22);
            this.txtSmtpPort.TabIndex = 6;
            // 
            // lblSMTP
            // 
            this.lblSMTP.AutoSize = true;
            this.lblSMTP.Location = new System.Drawing.Point(6, 140);
            this.lblSMTP.Name = "lblSMTP";
            this.lblSMTP.Size = new System.Drawing.Size(83, 17);
            this.lblSMTP.TabIndex = 5;
            this.lblSMTP.Text = "SMTP Host:";
            // 
            // txtSMTP
            // 
            this.txtSMTP.Location = new System.Drawing.Point(119, 137);
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(214, 22);
            this.txtSMTP.TabIndex = 4;
            // 
            // chkBoxUTF8
            // 
            this.chkBoxUTF8.AutoSize = true;
            this.chkBoxUTF8.Checked = true;
            this.chkBoxUTF8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxUTF8.Enabled = false;
            this.chkBoxUTF8.Location = new System.Drawing.Point(7, 61);
            this.chkBoxUTF8.Name = "chkBoxUTF8";
            this.chkBoxUTF8.Size = new System.Drawing.Size(354, 21);
            this.chkBoxUTF8.TabIndex = 3;
            this.chkBoxUTF8.Text = "Отправлять письмо в формате кодировкой UTF8";
            this.chkBoxUTF8.UseVisualStyleBackColor = true;
            // 
            // chkboxEmailFormat
            // 
            this.chkboxEmailFormat.AutoSize = true;
            this.chkboxEmailFormat.Checked = true;
            this.chkboxEmailFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxEmailFormat.Location = new System.Drawing.Point(6, 34);
            this.chkboxEmailFormat.Name = "chkboxEmailFormat";
            this.chkboxEmailFormat.Size = new System.Drawing.Size(276, 21);
            this.chkboxEmailFormat.TabIndex = 0;
            this.chkboxEmailFormat.Text = "Отправлять письмо в формате HTML";
            this.chkboxEmailFormat.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.pb);
            this.tabPage3.Controls.Add(this.btnExportToTxt);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btnLoadFileWithAutoValues);
            this.tabPage3.Controls.Add(this.txtFileWithAutoValues);
            this.tabPage3.Controls.Add(this.lbxReport);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(674, 440);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Автозначения и Отчет";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnExportToTxt
            // 
            this.btnExportToTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExportToTxt.ForeColor = System.Drawing.Color.Maroon;
            this.btnExportToTxt.Location = new System.Drawing.Point(384, 408);
            this.btnExportToTxt.Name = "btnExportToTxt";
            this.btnExportToTxt.Size = new System.Drawing.Size(284, 26);
            this.btnExportToTxt.TabIndex = 23;
            this.btnExportToTxt.Text = "Экспорт Отчета  в Текстовый файл";
            this.btnExportToTxt.UseVisualStyleBackColor = false;
            this.btnExportToTxt.Click += new System.EventHandler(this.btnExportToTxt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(3, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Файл с Aвтоподстановками";
            // 
            // btnLoadFileWithAutoValues
            // 
            this.btnLoadFileWithAutoValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLoadFileWithAutoValues.ForeColor = System.Drawing.Color.Maroon;
            this.btnLoadFileWithAutoValues.Location = new System.Drawing.Point(545, 33);
            this.btnLoadFileWithAutoValues.Name = "btnLoadFileWithAutoValues";
            this.btnLoadFileWithAutoValues.Size = new System.Drawing.Size(123, 28);
            this.btnLoadFileWithAutoValues.TabIndex = 19;
            this.btnLoadFileWithAutoValues.Text = "Перезагрузить!";
            this.btnLoadFileWithAutoValues.UseVisualStyleBackColor = false;
            this.btnLoadFileWithAutoValues.Click += new System.EventHandler(this.btnLoadFileWithAutoValues_Click);
            // 
            // txtFileWithAutoValues
            // 
            this.txtFileWithAutoValues.Enabled = false;
            this.txtFileWithAutoValues.Location = new System.Drawing.Point(6, 36);
            this.txtFileWithAutoValues.Name = "txtFileWithAutoValues";
            this.txtFileWithAutoValues.Size = new System.Drawing.Size(533, 22);
            this.txtFileWithAutoValues.TabIndex = 18;
            // 
            // lbxReport
            // 
            this.lbxReport.FormattingEnabled = true;
            this.lbxReport.HorizontalScrollbar = true;
            this.lbxReport.ItemHeight = 16;
            this.lbxReport.Location = new System.Drawing.Point(6, 101);
            this.lbxReport.Name = "lbxReport";
            this.lbxReport.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxReport.Size = new System.Drawing.Size(662, 244);
            this.lbxReport.TabIndex = 0;
            this.lbxReport.SelectedIndexChanged += new System.EventHandler(this.lbxReport_SelectedIndexChanged);
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pb.ForeColor = System.Drawing.Color.Yellow;
            this.pb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pb.Location = new System.Drawing.Point(6, 363);
            this.pb.Minimum = 1;
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(659, 27);
            this.pb.Step = 1;
            this.pb.TabIndex = 43;
            this.pb.Value = 1;
            // 
            // formEmailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 475);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "formEmailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправщик Письма Пользователям";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSelectAttach;
        private System.Windows.Forms.TextBox txtAttach1;
        private System.Windows.Forms.TextBox txtSubj;
        private System.Windows.Forms.RichTextBox richTxtEMailBody;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.TextBox txtBCCEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenderEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkboxEmailFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.CheckBox chkBoxUTF8;
        private System.Windows.Forms.ComboBox dllPrior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbxReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailTo;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblSMTP;
        private System.Windows.Forms.TextBox txtSMTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSmtpPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLoadFileWithAutoValues;
        private System.Windows.Forms.TextBox txtFileWithAutoValues;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnExportToTxt;
        internal System.Windows.Forms.ProgressBar pb;
    }
}

