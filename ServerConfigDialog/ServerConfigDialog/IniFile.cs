using System;
using System.Runtime.InteropServices; 
using System.Collections;
using System.Collections.Specialized;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace YXL
{
    ///  读写ini文件的类
    /**  调用kernel32.dll中的3个API：WritePrivateProfileString，GetPrivateProfileString，GetPrivateProfileSection
         来实现对ini文件的读写。
    */
    class IniFile
    {
        public IniFile(string iniFilePath)
        {
            string strAbsoluteDir = Path.GetDirectoryName(iniFilePath);
            if (!Directory.Exists(strAbsoluteDir))
                Directory.CreateDirectory(strAbsoluteDir);

            m_filePath = iniFilePath;
        }


        // 声明读写INI文件的API函数
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(
            string lpAppName,///< 指向包含 Section 名称的字符串地址
            string lpKeyName,///< 指向包含 Key 名称的字符串地址
            string lpString,///< 要写的字符串地址
            string lpFileName
            );

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(
            string lpAppName,///< 指向包含 Section 名称的字符串地址
            string lpKeyName,///< 指向包含 Key 名称的字符串地址
            string lpDefault,///< 如果 Key 值没有找到，则返回缺省的字符串的地址
            StringBuilder lpReturnedString,///< 返回字符串的缓冲区地址
            int nSize,///< 缓冲区的长度
            string lpFileName
            );

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileSection(
            string lpAppName,
            byte[] lpReturnedString,
            int nSize,
            string lpFileName
            );

        [DllImport("kernel32 ")]
        private static extern bool WritePrivateProfileSection(
                    string lpAppName,
                    string lpString,
                    string lpFileName
                ); 

        ///  写INI文件
        /**     @param[in] Section
                @param[in] Key
                @param[in] value
         */
        public void WriteValue(string section, string Key, string value)
        {
            WritePrivateProfileString(section, Key, value, this.m_filePath);
        }


        ///  读取INI文件指定部分
        /**     @param[in] Section
                @param[in] Key
                @returns String
         */
        public string ReadValue(string section, string Key)
        {
            return ReadValue(section, Key, "");
        }

        ///  读取INI文件指定部分
        /**     @param[in] Section
                @param[in] Key
                @param[in] DefaultValue
                @returns String
         */
        public string ReadValue(string section, string Key, string DefaultValue)
        {
            const int BUFFER_SIZE = 1024;
            StringBuilder temp = new StringBuilder(BUFFER_SIZE);
            GetPrivateProfileString(section, Key, DefaultValue, temp, BUFFER_SIZE, this.m_filePath);
            string strValue = temp.ToString().Trim();
            if (strValue != "")
                return strValue;
            else
                return DefaultValue;
        }


        /// 获取一个Section中的所有行
        /**
         * @param[out] lines 保存Section中的所有行的数据, 元素类型为string.
         */
        public void GetSection(string section, ArrayList lines)
        {
            const int MAX_SIZE = 32767;
            byte[] buffer = new byte[MAX_SIZE];
            int bufLen = 0;

            lines.Clear();

            bufLen = GetPrivateProfileSection(section, buffer, MAX_SIZE, m_filePath);
            if (bufLen > 0)
            {
                byte[] line = new byte[MAX_SIZE];
                int nPos = 0;
                for (int i = 0; i < bufLen; i++)
                {
                    if (buffer[i] != 0)
                    {
                        line[nPos++] = buffer[i];
                    }
                    else
                    {
                        if (nPos > 0)
                        {
                            lines.Add(Encoding.GetEncoding("GB2312").GetString(line, 0, nPos));
                            line = new byte[MAX_SIZE];
                            nPos = 0;
                        }
                    }
                }
            }
        }

        /// 保存一个Section中的所有行
        /**
         * @param lines 保存Section中的所有行的数据, 元素类型为string.
         */
        public void WriteSection(string section, ArrayList lines)
        {
            string buffer = "";
            int n = lines.Count;
            for (int i = 0; i < n; i++)
            {
                buffer += lines[i];
                buffer += "\0";
            }
            buffer += "\0";
            WritePrivateProfileSection(section, buffer, m_filePath); 
        }

        public string FileName
        {
            set 
            {
                m_filePath = value;
            }
            get
            {
                return m_filePath;
            }
        }

        ///  ini文件名称（带路径)
        private string m_filePath;

        /// 用户配置信息
        public static IniFile DefaultConfig
        {
            get
            {
				if (m_defaultConfig == null)
                {
					m_defaultConfig = new IniFile(Application.StartupPath + "config.ini");
                }
				return m_defaultConfig;
            }
        }

        /// 用户配置信息
        private static IniFile m_defaultConfig;
    }
}
