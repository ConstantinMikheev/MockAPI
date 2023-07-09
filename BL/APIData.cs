using Model;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BL
{
    public class APIData
    {
        private APIMethods methods;
        private Keys keys;
        private DataContent content;
        private string mainDir;
        private string pathAPIMethods;
        private string pathKeys;
        private string pathDataContentSettings;
        private string pathDataContentTemplate;

        public APIData(string mainDir)
        {
            this.mainDir = mainDir;
            pathAPIMethods = Path.Combine(mainDir, "APIMethods.json");
            pathKeys = Path.Combine(mainDir, "Keys.json");
            pathDataContentSettings = Path.Combine(mainDir, "DataContentSettings.json");
            pathDataContentTemplate = Path.Combine(mainDir, "DataContent\\{RequestString}\\");

            methods = LoadAPIMethods();
            keys = LoadKeys();
            content = LoadDataContent();
        }

        #region APIMethods
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
            if (!File.Exists(pathAPIMethods))
                return new APIMethods();

            var jsonText = File.ReadAllText(pathAPIMethods);
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
            if (!File.Exists(pathKeys))
                return new Keys();

            var jsonText = File.ReadAllText(pathKeys);
            var temp = JsonSerializer.Deserialize<List<KeyMethod[]>>(jsonText);

            return new Keys(temp);
        }
        #endregion

        #region DataContent
        public void AddContentRequestString(string requestString)
        {
            content.Add(requestString, methods);
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
            if (!File.Exists(pathDataContentSettings))
                return new DataContent();

            var jsonText = File.ReadAllText(pathDataContentSettings);
            var temp = JsonSerializer.Deserialize<string[]>(jsonText);

            var result = new DataContent();
            foreach (var item in temp)
                result.Add(item, methods);

            return result;
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
        #endregion
    }
}
