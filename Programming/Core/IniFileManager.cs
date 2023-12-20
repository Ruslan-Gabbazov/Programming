using System.IO;
using System.Text;

namespace Programming.Core
{
    public class IniFileManager
    {
        private readonly string _filePath;

        public IniFileManager(string filePath)
        {
            _filePath = filePath;
        }

        public bool FileExists()
        {
            return File.Exists(_filePath);
        }

        public void WriteIniFile(Config.Sections section, string key, object obj)
        {
            var value = obj.ToString();
            var ini = new StringBuilder();

            if (!FileExists())
            {
                ini.AppendLine("[" + section + "]");
                ini.AppendLine(key + "=" + value);
            }
            else
            {
                var lines = File.ReadAllLines(_filePath);

                var sectionExists = false;
                var keyExists = false;

                foreach (var line in lines)
                    if (line == "[" + section + "]")
                    {
                        sectionExists = true;
                        ini.AppendLine(line);
                    }
                    else if (line.StartsWith(key + "="))
                    {
                        keyExists = true;
                        ini.AppendLine(key + "=" + value);
                    }
                    else
                    {
                        ini.AppendLine(line);
                    }

                if (!sectionExists)
                {
                    ini.AppendLine("");
                    ini.AppendLine("[" + section + "]");
                    ini.AppendLine(key + "=" + value);
                }
                else if (!keyExists)
                {
                    ini.AppendLine(key + "=" + value);
                }
            }

            File.WriteAllText(_filePath, ini.ToString());
        }

        public string ReadIniFile(Config.Sections section, string key)
        {
            if (!FileExists()) return null;

            var lines = File.ReadAllLines(_filePath);
            var sectionExists = false;
            var keyExists = false;
            var value = "";

            foreach (var line in lines)
            {
                if (line == "[" + section + "]")
                {
                    sectionExists = true;
                }

                else if (sectionExists && line.StartsWith(key + "="))
                {
                    keyExists = true;
                    value = line.Substring(key.Length + 1);
                }

                if (sectionExists && keyExists) break;
            }

            if (!sectionExists || !keyExists) return null;

            return value;
        }
    }
}