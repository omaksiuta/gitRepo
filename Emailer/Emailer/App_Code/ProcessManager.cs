using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Diagnostics;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace Credit.IPV
{
    public class ProcessManager
    {

        FileHandler FlHler = new FileHandler();
        public bool startProcessWithArgs(string FilePath, string ProcessArgs = "", int TimeOutInSec = 30)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(FilePath);
                startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                startInfo.Arguments = ProcessArgs;
                startInfo.UseShellExecute = true;

                Process.Start(startInfo);
                Thread.Sleep(TimeOutInSec * 1000);
                return true;
            }
            catch 
            {
                return false;
            }

        }

        public bool killProcessByName(string prName)
        {
            try
            {

                prName = prName.Substring(0, prName.Length - 4);


                int CountofSubProcesses = 0;
                foreach (Process prcess in Process.GetProcessesByName(prName))
                {
                    //prcess.Close()
                    //prcess.WaitForExit(1000)
                    CountofSubProcesses = CountofSubProcesses + 1;
                    prcess.Kill();

                }

                Process[] runningProcesses = Process.GetProcesses();
                foreach (Process process in runningProcesses)
                {
                    if (process.ProcessName.ToUpper().Equals(prName.ToUpper()))
                    {
                        process.Kill();
                    }
                }


                Thread.Sleep(2 * 1000);
                return true;
            }
            catch 
            {

                return false;
            }

        }

        public double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }
    }
}
