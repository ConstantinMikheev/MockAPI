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
        private string mainDir;
        private string pathAPIMethods;
        private string pathKeys;

        public APIData(string mainDir)
        {
            this.mainDir = mainDir;
            pathAPIMethods = Path.Combine(mainDir, "APIMethods.json");
            pathKeys = Path.Combine(mainDir, "Keys.json");
            methods = LoadAPIMethods();
            keys = LoadKeys();
        }

        #region APIMethods
        public void AddAPIMethod(string method)
        {
            methods.Add(method);
        }

        public void RemoveAPIMethod(string method)
        {
            methods.Remove(method);
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

        public void SaveKeys()
        {
            SerializeToJSON(pathKeys, keys.PrepareForSerialization());
        }

        public Key GetKey(string id)
        {
            return keys.GetKey(id);
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
