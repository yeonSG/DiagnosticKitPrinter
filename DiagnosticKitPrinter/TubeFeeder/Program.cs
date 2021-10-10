using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TubeFeeder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            IniFileManager.IniFileExistCheckAndGenerateDefaultIniFIle();    // Setting.ini 파일 확인 및 생성
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.Run(new Form1());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            SmartX.SmartFile m_smartFile = m_smartFile = new SmartX.SmartFile();

            m_smartFile.FilePathName = "\\Flash Disk\\ErrorLog.txt";
            if (m_smartFile.Open() == true)
            {
                m_smartFile.WriteString(e.ToString());
                m_smartFile.Close();
            }
            else
            {
                ;
            }            
            // 처리되지 않는 모든 예외처리 코드 작성
        }
    }
}