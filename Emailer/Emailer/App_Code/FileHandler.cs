using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Credit.IPV
{
    public class FileHandler
    {

        public bool EnsureFileNameIsCorrect(string TextInIpvFileName)
        {
            if (!TextInIpvFileName.Contains("!")
                && !TextInIpvFileName.Contains("@")
                && !TextInIpvFileName.Contains("#")
                && !TextInIpvFileName.Contains("$")
                && !TextInIpvFileName.Contains("%")
                && !TextInIpvFileName.Contains("^")
                //&& !TextInIpvFileName.Contains("*")
                && !TextInIpvFileName.Contains("(")
                && !TextInIpvFileName.Contains(")")
                && !TextInIpvFileName.Contains("{")
                && !TextInIpvFileName.Contains("}")
                && !TextInIpvFileName.Contains("[")
                && !TextInIpvFileName.Contains("]")
                && !TextInIpvFileName.Contains(":")
                && !TextInIpvFileName.Contains(";")
                && !TextInIpvFileName.Contains(",")
                //&& !TextInIpvFileName.Contains(".")
                && !TextInIpvFileName.Contains("|")
                && !TextInIpvFileName.Contains("/"))
            {
                return true;
            }
            else
            {
                return false;
            }

            

        }


        public string DateTimeTextForFolderName()
        {
            return DateTime.Now.ToShortDateString().Replace("/", "-") + "_TestReports";
        }

        public string DateTimeTextForFileName()
        {
            //return DateTime.Now.ToString().Replace(":", "-").Replace("/", "-").Replace(" ", "_") + DateTime.Now.Millisecond;
            return DateTime.Now.ToString().Replace(":", "-").Replace("/", "-").Replace(" ", "_").Replace(".", "_") + DateTime.Now.Millisecond;

        }

        public string DateTimeTextForLogger()
        {
            return DateTime.Now.ToString().Replace(":", "-").Replace("/", "-").Replace(" ", "_") + "-" + DateTime.Now.Millisecond;

        }

        public string DateTimeTextForParamID()
        {
            return DateTime.Now.ToString().Replace(":", "").Replace("/", "").Replace(" ", "").Replace(".", "") + DateTime.Now.Millisecond;

        }

        public bool ReadFile(string FileToRead, string SearchString)
        {


            try
            {
                //FileToRead="C:\\DATA\\Temp\\qa.html";
                //SearchString="[11-19-2012_10-01-45_AM-1826]"

                using (StreamReader sr = new StreamReader(FileToRead))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(SearchString))
                        {
                            //MessageBox.Show("Text Found");
                            return true;
                        }
                    }
                }
                return false;
            }
            catch 
            {
                return false;
            }


        }



    }
}
