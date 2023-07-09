using Model;
using System.IO;
using System.Text.Json;

namespace BL
{
    public class APIData
    {
        private APIMethods methods;
        private string mainDir;
        private string pathAPIMethods;

        public APIData(string mainDir)
        {
            this.mainDir = mainDir;
            pathAPIMethods = Path.Combine(mainDir, "APIMethods.json");
            methods = LoadAPIMethods();
        }

        #region APIMethods
        public void AddAPIMethod(string method)
        {
            methods.Add(method);
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

        #region JSON serialization
        private void SerializeToJSON<T>(string path, T obj)
        {
            if (obj == null)
                return;
            var result = JsonSerializer.Serialize<T>(obj);
            File.WriteAllText(path, result);
        }
        #endregion
    }
}
