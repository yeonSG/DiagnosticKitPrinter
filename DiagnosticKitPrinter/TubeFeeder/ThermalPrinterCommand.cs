using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TubeFeeder
{
    public class ThermalPrinterCommand
    {
        // public const byte PROTOCOL_MESSAGE_SIZE = 7;

        public static readonly byte[] CMD_CRLF   = {0x0A, 0x0D};              // 줄바꿈
        public static readonly byte[] CMD_CUT_FULL   = {0x1D, 0x56, 0x00};    // 커팅(완벽하게 잘림)
        public static readonly byte[] CMD_CUT_PART   = {0x1D, 0x56, 0x01};    // 커팅(약간 남겨둠)
        public static readonly byte[] CMD_FONT_X1   = {0x1D, 0x21, 0x00};     // 글자크기 1배
        public static readonly byte[] CMD_FONT_X2   = {0x1D, 0x21, 0x11};     // 글자크기 2배
    
        public static readonly byte[] TEST_TEXT1   = {0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x20, 0x2E, 0x2E, 0x2E, 0x20, 0x4F, 0x4B};                // 123456789 ... OK
        public static readonly byte[] TEST_TEXT2   = {0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x20, 0x2E, 0x2E, 0x2E, 0x20, 0x46, 0x41, 0x49, 0x4C};  // 123456789 ... FAIL


        /*
         * 두개의 byte[] 를 하나로 합쳐줌
         */
        public static byte[] concatArray(byte[] arrayA, byte[] arrayB)
        {
            var mergedArray = new byte[arrayA.Length + arrayB.Length];
            arrayA.CopyTo(mergedArray, 0);
            arrayB.CopyTo(mergedArray, arrayA.Length);

            return mergedArray;
        }

        // 한글 -> byte
        public static byte[] stringToByteArray(string str) 
        {
            // char uchars = str.ToCharArray();
            // return System.Text.Encoding.Unicode.GetBytes(str);
            return System.Text.ASCIIEncoding.Default.GetBytes(str);
        }
    }
}

