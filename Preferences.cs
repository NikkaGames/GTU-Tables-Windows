using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace GTU_Tables_Windows
{
    public class Preferences
    {
        private string filePath;
        private Dictionary<string, object> data;

        public Preferences(string fileName)
        {
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "GTU-Tables-Windows",
                fileName
            );
            string prefsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "GTU-Tables-Windows"
            );
            Directory.CreateDirectory(prefsPath);
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                data = JsonConvert.DeserializeObject<Dictionary<string, object>>(json) ?? new Dictionary<string, object>();
            }
            else
            {
                data = new Dictionary<string, object>();
            }
        }

        public void PutString(string key, string value)
        {
            data[key] = value;
            Save();
        }

        public string GetString(string key, string defaultValue = "")
        {
            return data.ContainsKey(key) ? data[key].ToString() : defaultValue;
        }

        public void PutBool(string key, bool value)
        {
            data[key] = value;
            Save();
        }

        public bool GetBool(string key, bool defaultValue = false)
        {
            return data.ContainsKey(key) ? Convert.ToBoolean(data[key]) : defaultValue;
        }

        private void Save()
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
