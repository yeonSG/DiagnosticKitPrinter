using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TubeFeeder
{
    class IniFile
    {
        /*
         * Checkmate / 2010.08
         * IniFile 클래스는 Ini를 읽고 쓸 수 있도록 구현한 것이다.
         * 동일한 함수명을 가진 static함수와 일반함수로 나누어져 있다.
         *
         * 한 두 번만 사용할 경우에는 인스턴스 생성 없이 static함수를 이용하여 사용하면 된다.
         * 개체의 생성 소멸이 필요 없다.
         * 매번 지정된 파일을 찾아야 한다.
         *
         * 동일한 파일에 여러번 사용할 경우에는 인스턴스를 생성하여 사용하는 것이 좋다.
         * 내부적으로 FileInfo개체를 생성하여 파일을 검색하는 시간을 절약하도록 구현됐다.
         * 따라서 생성 시에 파일이름을 전달하여야 한다. IniFile ini = new IniFile("C:\\Temp\\Test.ini");
         *
         * ReadString() : ini에서 문자열 값을 읽어 온다.
         * ReadInteger() : ini에서 정수(int32) 값을 읽어 온다.
         * ReadBool() : ini에서 bool 값을 읽어 온다.
         *
         * WriteString() : ini에 문자열 값을 쓴다.
         * WriteInteger() : ini에 정수(int32) 값을 쓴다.
         * WriteBool() : ini에 bool 값을 쓴다.
         */

        FileInfo fi;

        public IniFile(String filename)
        {
            //파일 검색 과정을 줄이기 위해 파일정보를 클래스 생성 시 파일 정보를 설정한다.
            fi = new FileInfo(filename);
        }

        public int ReadInteger(String sSect, String sKey, int defaultvalue)
        {
            String sValue;
            sValue = defaultvalue.ToString();
            sValue = ReadString(sSect, sKey, sValue);
            return Convert.ToInt32(sValue);
        }

        public bool ReadBool(String sSect, String sKey, bool defaultvalue)
        {
            String sValue;
            if (defaultvalue == true)
            {
                sValue = "1";
            }
            else
            {
                sValue = "0";
            }
            sValue = ReadString(sSect, sKey, sValue);

            if (sValue == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String ReadString(String sSect, String sKey, String defaultvalue)
        {
            if (fi.Exists == false)
            {
                return defaultvalue;
            }
            String result = defaultvalue;
            String strLine;

            String[] strArr;
            char[] tokenArr = new char[] { '=' };

            bool bFindSect = false;
            int nOffset1;
            int nOffset2;

            FileStream fs = fi.OpenRead();
            StreamReader sr = new StreamReader(fs);
            sSect = "[" + sSect.ToUpper() + "]";
            sKey = sKey.ToUpper();

            strLine = sr.ReadLine();

            while (strLine != null)
            {
                nOffset1 = strLine.IndexOf(']');
                if (strLine == "") //빈라인은 처리
                {
                    //
                }
                else if ((strLine[0] == '[') && (nOffset1 > 1)) //해당 라인이 섹션이름인가
                {

                    if (bFindSect == true)
                    {
                        //섹션을 찾았다가 변경 되었으므로 진행 종료. //섹션은 동일한 것이 여러번 나타날 수 없다.
                        break;
                    }
                    else
                    {
                        if (strLine.ToUpper() == sSect) //Section Name 찾기
                        {
                            //섹션이름을 찾았음
                            bFindSect = true;
                        }
                    }
                }
                else
                {
                    if (bFindSect)
                    {
                        //현재 섹션에서 진행중
                        nOffset2 = strLine.IndexOf('=');
                        if (nOffset2 > 0)
                        {
                            //key 영역
                            strArr = strLine.Split(tokenArr);
                            if (strArr.GetUpperBound(0) > 0)
                            {
                                if (strArr[0].ToUpper() == sKey)
                                {
                                    //KeyName 일치 - Found
                                    //값에 '='가 있을 수 있으므로 반복처리
                                    result = "";
                                    for (int i = 1; i <= strArr.GetUpperBound(0); i++)
                                    {
                                        result += strArr[i];
                                    }
                                    break;
                                }
                            } //if (strArr.GetUpperBound(0) == 1)

                        } //if (nOffset2 > 0)
                    } //if (bFindSect)
                } //else

                strLine = sr.ReadLine();
            } //while

            sr.Close();
            fs.Close();
            return result;
        }

        public bool WriteString(String sSect, String sKey, String sValue)
        {
            bool result = false;
            String strLine;
            String sectname;
            String keyname;
            String[] strArr;
            char[] tokenArr = new char[] { '=' };

            bool bFindSect = false;
            bool bFindKey = false;
            int nOffset1;
            int nOffset2;

            FileStream fs;

            FileStream fs2;

            StreamWriter sw;



            // String sTempFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IniTemp.ini";;
            String sTempFile = "\\Flash Disk\\IniTemp.ini";

            if (fi.Exists == false)
            {
                //파일이 없을 경우
                fs2 = new FileStream(fi.FullName, FileMode.OpenOrCreate);
                sw = new StreamWriter(fs2);

                sw.WriteLine("[" + sSect + "]");
                sw.WriteLine("{0}={1}", sKey, sValue);
                sw.Close();

                fs2.Close();
                fi.Refresh(); //정보를 갱신해야 다음에 Exists가 처리된다.

                return true;
            }

            //FileStream fs = fi.OpenRead();
            //FileStream fs2 = new FileStream(sTempFile, FileMode.OpenOrCreate);

            //StreamWriter sw = new StreamWriter(fs2);

            fs = fi.OpenRead();

            fs2 = new FileStream(sTempFile, FileMode.OpenOrCreate);

            sw = new StreamWriter(fs2);

            StreamReader sr = new StreamReader(fs);

            sectname = "[" + sSect.ToUpper() + "]";
            keyname = sKey.ToUpper();

            strLine = sr.ReadLine();

            while (strLine != null)
            {
                nOffset1 = strLine.IndexOf(']');
                if (strLine == "") //빈라인은 처리
                {
                    sw.WriteLine("");
                }
                else if ((strLine[0] == '[') && (nOffset1 > 1)) //해당 라인이 섹션이름인가
                {

                    if (bFindSect == true)
                    {
                        //섹션을 찾았다가 변경 되었음 //섹션은 동일한 것이 여러번 나타날 수 없다.
                        if (bFindKey == false)
                        {
                            //해당키 찾지 못함 //키 추가
                            sw.WriteLine("{0}={1}", sKey, sValue);
                            result = true;
                            bFindKey = true;
                        }
                        sw.WriteLine(strLine);
                    }
                    else
                    {
                        if (strLine.ToUpper() == sectname) //Section Name 찾기
                        {
                            //섹션이름을 찾았음
                            bFindSect = true;
                        }
                        sw.WriteLine(strLine);
                    }

                }
                else
                {
                    if (bFindSect)
                    {
                        //현재 섹션에서 진행중
                        nOffset2 = strLine.IndexOf('=');
                        if (bFindKey)
                        {
                            //키값을 이미 처리되었음 //그냥 복사만
                            sw.WriteLine(strLine);
                        }
                        else if (nOffset2 > 0)
                        {
                            //key 영역
                            strArr = strLine.Split(tokenArr);
                            if (strArr.GetUpperBound(0) > 0)
                            {
                                if (strArr[0].ToUpper() == keyname)
                                {
                                    //KeyName 일치 - Found
                                    sw.WriteLine("{0}={1}", strArr[0], sValue); //기존 키이름 보존
                                    result = true;
                                    bFindKey = true;
                                }
                                else
                                {
                                    sw.WriteLine(strLine);
                                }
                            } //if (strArr.GetUpperBound(0) == 1)
                            else
                            {
                                sw.WriteLine(strLine);
                            }

                        } //if (nOffset2 > 0)
                    } //if (bFindSect)
                    else
                    {
                        sw.WriteLine(strLine);
                    }
                } //else

                strLine = sr.ReadLine();
            } //while

            //키를 찾지 못했으면 새로이 추가
            if (bFindKey == false)
            {
                if (bFindSect == false) //섹션도 못 찾았을 경우 추가
                {
                    sw.WriteLine("[" + sSect + "]");
                }
                sw.WriteLine("{0}={1}", sKey, sValue);
                result = true;
            }

            sr.Close();
            fs.Close();
            sw.Close();
            fs2.Close();

            File.Copy(sTempFile, fi.FullName, true); //원본 파일에 임시파일 덮어쓰기
            File.Delete(sTempFile); //임시 파일 삭제

            return result;
        }

        public bool WriteInteger(String sSect, String sKey, int value)
        {
            String sValue;
            sValue = value.ToString();
            return WriteString(sSect, sKey, sValue);
        }

        public bool WriteBool(String sSect, String sKey, bool value)
        {
            String sValue;
            if (value == true)
            {
                sValue = "1";
            }
            else
            {
                sValue = "0";
            }
            return WriteString(sSect, sKey, sValue);
        }

        //static 함수
        public static int ReadInteger(String sFile, String sSect, String sKey, int defaultvalue)
        {
            String sValue;
            int nValue;
            sValue = defaultvalue.ToString();
            sValue = ReadString(sFile, sSect, sKey, sValue);
            try
            {
                nValue = Convert.ToInt32(sValue);
                return nValue;
            }
            catch (System.Exception e)
            {
                return defaultvalue;
            }
        }

        public static bool ReadBool(String sFile, String sSect, String sKey, bool defaultvalue)
        {
            String sValue;
            if (defaultvalue == true)
            {
                sValue = "1";
            }
            else
            {
                sValue = "0";
            }
            sValue = ReadString(sFile, sSect, sKey, sValue);

            if (sValue == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static String ReadString(String sFile, String sSect, String sKey, String defaultvalue)
        {
            if (File.Exists(sFile) == false)
            {
                return defaultvalue;
            }

            String result = defaultvalue;
            String strLine;

            String[] strArr;
            char[] tokenArr = new char[] { '=' };

            bool bFindSect = false;
            int nOffset1;
            int nOffset2;

            FileStream fs = new FileStream(sFile, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            sSect = "[" + sSect.ToUpper() + "]";
            sKey = sKey.ToUpper();

            strLine = sr.ReadLine();

            while (strLine != null)
            {
                nOffset1 = strLine.IndexOf(']');
                if (strLine == "") //빈라인은 처리
                {
                    //
                }
                else if ((strLine[0] == '[') && (nOffset1 > 1)) //해당 라인이 섹션이름인가
                {

                    if (bFindSect == true)
                    {
                        //섹션을 찾았다가 변경 되었으므로 진행 종료. //섹션은 동일한 것이 여러번 나타날 수 없다.
                        break;
                    }
                    else
                    {
                        if (strLine.ToUpper() == sSect) //Section Name 찾기
                        {
                            //섹션이름을 찾았음
                            bFindSect = true;
                        }
                    }
                }
                else
                {
                    if (bFindSect)
                    {
                        //현재 섹션에서 진행중
                        nOffset2 = strLine.IndexOf('=');
                        if (nOffset2 > 0)
                        {
                            //key 영역
                            strArr = strLine.Split(tokenArr);
                            if (strArr.GetUpperBound(0) > 0)
                            {
                                if (strArr[0].ToUpper() == sKey)
                                {
                                    //KeyName 일치 - Found
                                    //값에 '='가 있을 수 있으므로 반복처리
                                    result = "";
                                    for (int i = 1; i <= strArr.GetUpperBound(0); i++)
                                    {
                                        result += strArr[i];
                                    }
                                    break;
                                }
                            } //if (strArr.GetUpperBound(0) == 1)

                        } //if (nOffset2 > 0)
                    } //if (bFindSect)
                } //else

                strLine = sr.ReadLine();
            } //while

            sr.Close();
            fs.Close();
            return result;
        }

        public static bool WriteString(String sFile, String sSect, String sKey, String sValue)
        {
            bool result = false;
            String strLine;
            String sectname;
            String keyname;
            String[] strArr;
            char[] tokenArr = new char[] { '=' };

            bool bFindSect = false;
            bool bFindKey = false;
            int nOffset1;
            int nOffset2;

            //String sTempFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IniTemp.ini";
            String sTempFile = "\\Flash Disk\\IniTemp.ini";

            FileStream fs = new FileStream(sFile, FileMode.OpenOrCreate);
            FileStream fs2 = new FileStream(sTempFile, FileMode.OpenOrCreate);

            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs2);

            sectname = "[" + sSect.ToUpper() + "]";
            keyname = sKey.ToUpper();

            strLine = sr.ReadLine();

            while (strLine != null)
            {
                nOffset1 = strLine.IndexOf(']');
                if (strLine == "") //빈라인은 처리
                {
                    sw.WriteLine("");
                }
                else if ((strLine[0] == '[') && (nOffset1 > 1)) //해당 라인이 섹션이름인가
                {

                    if (bFindSect == true)
                    {
                        //섹션을 찾았다가 변경 되었음 //섹션은 동일한 것이 여러번 나타날 수 없다.
                        if (bFindKey == false)
                        {
                            //해당키 찾지 못함 //키 추가
                            sw.WriteLine("{0}={1}", sKey, sValue);
                            result = true;
                            bFindKey = true;
                        }
                        sw.WriteLine(strLine);
                    }
                    else
                    {
                        if (strLine.ToUpper() == sectname) //Section Name 찾기
                        {
                            //섹션이름을 찾았음
                            bFindSect = true;
                        }
                        sw.WriteLine(strLine);
                    }

                }
                else
                {
                    if (bFindSect)
                    {
                        //현재 섹션에서 진행중
                        nOffset2 = strLine.IndexOf('=');
                        if (bFindKey)
                        {
                            //키값을 이미 처리되었음 //그냥 복사만
                            sw.WriteLine(strLine);
                        }
                        else if (nOffset2 > 0)
                        {
                            //key 영역
                            strArr = strLine.Split(tokenArr);
                            if (strArr.GetUpperBound(0) > 0)
                            {
                                if (strArr[0].ToUpper() == keyname)
                                {
                                    //KeyName 일치 - Found
                                    sw.WriteLine("{0}={1}", strArr[0], sValue); //기존 키 이름 보존
                                    result = true;
                                    bFindKey = true;
                                }
                                else
                                {
                                    sw.WriteLine(strLine);
                                }
                            } //if (strArr.GetUpperBound(0) == 1)
                            else
                            {
                                sw.WriteLine(strLine);
                            }

                        } //if (nOffset2 > 0)
                    } //if (bFindSect)
                    else
                    {
                        sw.WriteLine(strLine);
                    }
                } //else

                strLine = sr.ReadLine();
            } //while

            //키를 찾지 못했으면 새로이 추가
            if (bFindKey == false)
            {
                if (bFindSect == false) //섹션도 못 찾았을 경우 추가
                {
                    sw.WriteLine("[" + sSect + "]");
                }
                sw.WriteLine("{0}={1}", sKey, sValue);
                result = true;
            }

            sr.Close();
            fs.Close();
            sw.Close();
            fs2.Close();

            File.Copy(sTempFile, sFile, true);
            File.Delete(sTempFile);

            return result;
        }

        public static bool WriteInteger(String sFile, String sSect, String sKey, int value)
        {
            String sValue;
            sValue = value.ToString();
            return WriteString(sFile, sSect, sKey, sValue);
        }

        public static bool WriteBool(String sFile, String sSect, String sKey, bool value)
        {
            String sValue;
            if (value == true)
            {
                sValue = "1";
            }
            else
            {
                sValue = "0";
            }
            return WriteString(sFile, sSect, sKey, sValue);
        }
    }
}