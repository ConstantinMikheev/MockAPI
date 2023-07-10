using Model;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BL
{
    public class APIData
    {
        private Settings settings;
        private APIMethods methods;
        private Keys keys;
        private DataContent content;

        private string mainDir;
        private string pathSettings;
        private string pathAPIMethods;
        private string pathKeys;
        private string pathDataContentSettings;
        private string pathDataContentTemplate;

        public APIData(string mainDir)
        {
            this.mainDir = mainDir;
            pathSettings = Path.Combine(mainDir, "Settings.json");
            pathAPIMethods = Path.Combine(mainDir, "APIMethods.json");
            pathKeys = Path.Combine(mainDir, "Keys.json");
            pathDataContentSettings = Path.Combine(mainDir, "DataContentSettings.json");
            pathDataContentTemplate = Path.Combine(mainDir, "DataContent\\{RequestString}\\{APIMethod}.json");

            settings = LoadSettings();
            methods = LoadAPIMethods();
            keys = LoadKeys();
            content = LoadDataContent();
        }

        #region Settings
        public void AddDownloadKey(string key)
        {
            settings.AddKey(key);
        }

        public void RemoveDownloadKey(string key)
        {
            settings.RemoveKey(key);
        }

        public Settings GetSettings()
        {
            return settings;
        }

        public void SaveSettings()
        {
            SerializeToJSON(pathSettings, settings);
        }

        public Settings LoadSettings()
        {
            var jsonText = ReadJSONFromFile(pathSettings);
            if (jsonText == null)
                return new Settings();
            var temp = JsonSerializer.Deserialize<Settings>(jsonText);

            if (temp == null)
                return new Settings();
            else
                return temp;
        }
        #endregion

        #region APIMethods
        public APIMethods GetAPIMethods()
        {
            return methods;
        }

        public void AddAPIMethod(string method)
        {
            methods.Add(method);
            keys.AddMethod(method);
            var apiMethod = methods.GetMethod(method);
            content.AddMethod(apiMethod);
        }

        public void RemoveAPIMethod(string method)
        {
            methods.Remove(method);
            keys.RemoveMethod(method);
            content.RemoveMethod(method);
        }

        public APIMethod GetAPIMethod(string method)
        {
            return methods.GetMethod(method);
        }

        public void SaveAPIMethods()
        {
            SerializeToJSON(pathAPIMethods, methods.PrepareForSerialization());
        }

        public APIMethods LoadAPIMethods()
        {
            var jsonText = ReadJSONFromFile(pathAPIMethods);
            if (jsonText == null)
                return new APIMethods();
            var temp = JsonSerializer.Deserialize<APIMethod[]>(jsonText);

            return new APIMethods(temp);
        }
        #endregion

        #region Keys
        public void AddKey(string key)
        {
            keys.Add(key, methods);
        }

        public void RemoveKey(string key)
        {
            keys.Remove(key);
        }

        public Key GetKey(string id)
        {
            return keys.GetKey(id);
        }

        public void SaveKeys()
        {
            SerializeToJSON(pathKeys, keys.PrepareForSerialization());
        }

        public Keys LoadKeys()
        {
            var jsonText = ReadJSONFromFile(pathKeys);
            if (jsonText == null)
                return new Keys();
            var temp = JsonSerializer.Deserialize<List<KeyMethod[]>>(jsonText);

            return new Keys(temp);
        }
        #endregion

        #region DataContent
        public DataContent GetDataContent()
        {
            return content;
        }

        public void AddContentRequestString(string requestString)
        {
            content.Add(requestString, methods, pathDataContentTemplate);
        }

        public void RemoveContentRequestString(string requestString)
        {
            content.Remove(requestString);
        }

        public DataMethodContent[] GetContent(string requestString)
        {
            return content.GetDataMethodContents(requestString);
        }

        public void SaveDataContentSettings()
        {
            SerializeToJSON(pathDataContentSettings, content.PrepareForSerialization());
        }

        public DataContent LoadDataContent()
        {
            var jsonText = ReadJSONFromFile(pathDataContentSettings);
            if (jsonText == null)
                return new DataContent();
            var temp = JsonSerializer.Deserialize<string[]>(jsonText);

            var result = new DataContent();
            foreach (var item in temp)
                result.Add(item, methods, pathDataContentTemplate);

            return result;
        }

        public void LoadDataFromAPI(List<string> requestsStrings)
        {
            foreach (var requestString in requestsStrings)
            {
                var dataMethods = content.GetDataMethodContents(requestString);
                foreach (var item in dataMethods)
                {
                    var curMethod = item.ApiMethod;
                    if (!curMethod.Enabled)
                        continue;
                    string contentString;
                    if (string.IsNullOrEmpty(curMethod.ResourceString))
                        if (string.IsNullOrEmpty(settings.ResourceStringTemplate))
                            continue;
                        else
                            contentString = settings.ResourceStringTemplate;
                    else
                        contentString = curMethod.ResourceString;
                    contentString = contentString.Replace("{MethodName}", curMethod.Name);
                    contentString = contentString.Replace("{RequestString}", requestString);
                    for(int i = 0; i < settings.Keys.Count; i++)
                    {
                        var tempKey = "{Key" + (i + 1).ToString() + "}";
                        contentString = contentString.Replace(tempKey, settings.Keys[i]);
                    }
                    contentString = settings.ServerAPI + contentString;
                    if (!Directory.Exists(Path.Combine(mainDir, $"DataContent\\{requestString}")))
                        Directory.CreateDirectory(Path.Combine(mainDir, $"DataContent\\{requestString}"));
                    Downloader.Download(contentString, item.ContentPath);
                }
            }
        }
        #endregion

        #region JSON serialization
        private void SerializeToJSON<T>(string path, T obj)
        {
            if (obj == null)
                return;

            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            var result = JsonSerializer.Serialize<T>(obj, options);
            File.WriteAllText(path, result);
        }

        private string ReadJSONFromFile(string path)
        {
            if (!File.Exists(path))
                return null;

            string result;
            try
            {
                result = File.ReadAllText(path);
                if (string.IsNullOrWhiteSpace(result))
                    result = null;
            } catch
            {
                result = null;
            }

            return result;
        }
        #endregion
    }
}
