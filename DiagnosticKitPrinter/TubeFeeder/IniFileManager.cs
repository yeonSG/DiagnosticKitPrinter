using System;
using System.IO;

namespace TubeFeeder
{
    class IniFileManager
    {
        public const string INIFILE_PATH = "\\Flash Disk\\Settings.ini";
        public const string SECTION_COMPORT = "COMPORT";
        public const string SECTION_LOGFILE = "LOGFILE";
        public const string SECTION_MODE = "MODE";
        public const string SECTION_SETTING = "SETTING";
        
        public const string SECTION_COMPORT_MCU_COM = "MCU_COM";
        public const string SECTION_COMPORT_MCU_BAUDRATE = "MCU_BAUDRATE";

        public const string SECTION_COMPORT_PRINTER_COM = "PRINTER_COM";
        public const string SECTION_COMPORT_PRINTER_BAUDRATE = "PRINTER_BAUDRATE";

        public const string SECTION_LOGFILE_DIR = "LOGFILE_DIR";

        public const string SECTION_MODE_BARCODEREAD = "BARCODE_READ";
        public const string SECTION_MODE_AUTOSTOP = "AUTO_STOP";

        public const string SECTION_SETTING_CONVEYERSPEED = "CONV_SPEED";
        public const string SECTION_SETTING_XXAIXDISTANCE = "X_DISTANCE";
        public const string SECTION_SETTING_ROLLERSPEED = "CON_ROLLER_SPEED";

        /* Default 값 */
        public const string SECTION_COMPORT_MCU_COM_DEFAULT = "COM4";
        public const int SECTION_COMPORT_MCU_BAUDRATE_DEFAULT = 115200;
        public const string SECTION_COMPORT_PRINTER_COM_DEFAULT = "COM3";
        public const int SECTION_COMPORT_PRINTER_BAUDRATE_DEFAULT = 19200;

        public const string SECTION_LOGFILE_DIR_DEFAULT = "\\Flash Disk\\ScanLog";

        public const bool SECTION_MODE_BARCODEREAD_DEFAULT = true;
        public const bool SECTION_MODE_AUTOSTOP_DEFAULT = true;

        public const int SECTION_SETTING_CONVEYERSPEED_DEFAULT = 3;
        public const int SECTION_SETTING_XXAIXDISTANCE_DEFAULT = 7;
        public const int SECTION_SETTING_ROLLERSPEED_DEFAULT = 2;

        public static string GetComport_MCU_COM()
        {
            return IniFile.ReadString(INIFILE_PATH, SECTION_COMPORT, SECTION_COMPORT_MCU_COM, SECTION_COMPORT_MCU_COM_DEFAULT);
        }
        public static int GetComport_MCU_BaudRate()
        {
            return IniFile.ReadInteger(INIFILE_PATH, SECTION_COMPORT, SECTION_COMPORT_MCU_BAUDRATE, SECTION_COMPORT_MCU_BAUDRATE_DEFAULT);
        }
        
        public static string GetComport_Printer_COM()
        {
            return IniFile.ReadString(INIFILE_PATH, SECTION_COMPORT, SECTION_COMPORT_PRINTER_COM, SECTION_COMPORT_PRINTER_COM_DEFAULT);
        }
        public static int GetComport_Printer_BaudRate()
        {
            return IniFile.ReadInteger(INIFILE_PATH, SECTION_COMPORT, SECTION_COMPORT_PRINTER_BAUDRATE, SECTION_COMPORT_PRINTER_BAUDRATE_DEFAULT);
        }

        public static string GetLogFIle_Dir()
        {
            return IniFile.ReadString(INIFILE_PATH, SECTION_LOGFILE, SECTION_LOGFILE_DIR, SECTION_LOGFILE_DIR_DEFAULT);
        }

        // Mode
        public static bool GetMode_BarcodeRead()
        {
            return IniFile.ReadBool(INIFILE_PATH, SECTION_MODE, SECTION_MODE_BARCODEREAD, SECTION_MODE_BARCODEREAD_DEFAULT);
        }
        public static bool GetMode_AutoStop()
        {
            return IniFile.ReadBool(INIFILE_PATH, SECTION_MODE, SECTION_MODE_AUTOSTOP, SECTION_MODE_AUTOSTOP_DEFAULT);
        }

        // Settings
        public static int GetSetting_ConveyerSpeed()
        {
            return IniFile.ReadInteger(INIFILE_PATH, SECTION_SETTING, SECTION_SETTING_CONVEYERSPEED, SECTION_SETTING_CONVEYERSPEED_DEFAULT);
        }
        public static int GetSetting_XXaisDistance()
        {
            return IniFile.ReadInteger(INIFILE_PATH, SECTION_SETTING, SECTION_SETTING_XXAIXDISTANCE, SECTION_SETTING_XXAIXDISTANCE_DEFAULT);
        }
        public static int GetSetting_ConverterRollerSpeed()
        {
            return IniFile.ReadInteger(INIFILE_PATH, SECTION_SETTING, SECTION_SETTING_ROLLERSPEED, SECTION_SETTING_ROLLERSPEED_DEFAULT);
        }

        public static void IniFileExistCheckAndGenerateDefaultIniFIle()
        {
            if (IniFileExistCheck() == false)
                GenerateDefaultIniFile();
        }
        public static bool IniFileExistCheck()
        {
            FileInfo fileInfo = new FileInfo(INIFILE_PATH);
            return fileInfo.Exists;
        }

        public static void GenerateDefaultIniFile()
        {
            IniFile.WriteString(INIFILE_PATH, SECTION_COMPORT, SECTION_COMPORT_MCU_COM, SECTION_COMPORT_MCU_COM_DEFAULT);
            IniFile.WriteInteger(INIFILE_PATH, SECTION_COMPORT, SECTION_COMPORT_MCU_BAUDRATE, SECTION_COMPORT_MCU_BAUDRATE_DEFAULT);
            
            IniFile.WriteString(INIFILE_PATH, SECTION_COMPORT, SECTION_COMPORT_PRINTER_COM, SECTION_COMPORT_PRINTER_COM_DEFAULT);
            IniFile.WriteInteger(INIFILE_PATH, SECTION_COMPORT, SECTION_COMPORT_PRINTER_BAUDRATE, SECTION_COMPORT_PRINTER_BAUDRATE_DEFAULT);

            IniFile.WriteString(INIFILE_PATH, SECTION_LOGFILE, SECTION_LOGFILE_DIR, SECTION_LOGFILE_DIR_DEFAULT);

            IniFile.WriteBool(INIFILE_PATH, SECTION_MODE, SECTION_MODE_BARCODEREAD, SECTION_MODE_BARCODEREAD_DEFAULT);
            IniFile.WriteBool(INIFILE_PATH, SECTION_MODE, SECTION_MODE_AUTOSTOP, SECTION_MODE_AUTOSTOP_DEFAULT);

            IniFile.WriteInteger(INIFILE_PATH, SECTION_SETTING, SECTION_SETTING_CONVEYERSPEED, SECTION_SETTING_CONVEYERSPEED_DEFAULT);
            IniFile.WriteInteger(INIFILE_PATH, SECTION_SETTING, SECTION_SETTING_XXAIXDISTANCE, SECTION_SETTING_XXAIXDISTANCE_DEFAULT);
            IniFile.WriteInteger(INIFILE_PATH, SECTION_SETTING, SECTION_SETTING_ROLLERSPEED, SECTION_SETTING_ROLLERSPEED_DEFAULT);

        }

        // Mode
        public static void SetMode_BarcodeRead(bool value)
        {
            IniFile.WriteBool(INIFILE_PATH, SECTION_MODE, SECTION_MODE_BARCODEREAD, value);
        }
        public static void SetMode_AutoStop(bool value)
        {
            IniFile.WriteBool(INIFILE_PATH, SECTION_MODE, SECTION_MODE_AUTOSTOP, value);
        }

        // Settings
        public static void SetSetting_ConveyerSpeed(int value)
        {
            IniFile.WriteInteger(INIFILE_PATH, SECTION_SETTING, SECTION_SETTING_CONVEYERSPEED, value);
        }
        public static void SetSetting_XXaisDistance(int value)
        {
            IniFile.WriteInteger(INIFILE_PATH, SECTION_SETTING, SECTION_SETTING_XXAIXDISTANCE, value);
        }
        public static void SetSetting_ConverterRollerSpeed(int value)
        {
            IniFile.WriteInteger(INIFILE_PATH, SECTION_SETTING, SECTION_SETTING_ROLLERSPEED, value);
        }
        
    }
}
