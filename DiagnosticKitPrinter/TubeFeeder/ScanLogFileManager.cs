using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TubeFeeder
{
    class ScanLogFileManager 
    {
        public const string DIR_DELIMITER = "\\";
        public string LOGFILE_PATH = IniFileManager.GetLogFIle_Dir();     

        public static string mLastWriteValue = "";

        SmartX.SmartFile m_smartFile;

        public ScanLogFileManager()
        {
            this.m_smartFile = new SmartX.SmartFile();
        }

        public bool WriteValue(string value)
        {
            if (mLastWriteValue.Equals(value) == true)
            {
                return true; //  Do not action, When Duplicated before Input value.
            }
            else
            {
                mLastWriteValue = value;
            }

            EvaluatePath(GetLogFIlePath());
            m_smartFile.FilePathName = GetTargetFile();
            if (m_smartFile.Open() == true)
            {
                m_smartFile.WriteString( GetCurrentTime() +"\t"+ value ); 
                m_smartFile.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool EvaluatePath(String path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine(ioex.Message);
                return false;
            }
            return true;
        }
        public string GetLogFIlePath()
        {
            return LOGFILE_PATH;
        }
        public string GetTargetFile()
        {
            return LOGFILE_PATH + DIR_DELIMITER + GetCurrentDate() + ".txt";
        }

        public string GetCurrentDate()
        {
            return DateTime.Now.ToString("yyyyMMdd");
        }

        public string GetCurrentTime()
        {
            return String.Format("{0,2:N0}:{1,2:N0}:{2,2:N0}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
    }
}
