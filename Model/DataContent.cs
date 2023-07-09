using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class DataContent: IEnumerable
    {
        private Dictionary<string, List<DataMethodContent>> content;

        #region Constructors
        public DataContent()
        {
            content = new Dictionary<string, List<DataMethodContent>>();
        }
        #endregion

        #region Interface methods
        public IEnumerator GetEnumerator()
        {
            foreach(var item in content)
                yield return item;
        }
        #endregion

        #region Other methods
        public void Add(string requestString)
        {
            if (content.ContainsKey(requestString))
                throw new Exception($"Строка запроса контента {requestString} уже существует.");

            content.Add(requestString, new List<DataMethodContent>());
        }

        public void Add(string requestString, APIMethods methods)
        {
            if (content.ContainsKey(requestString))
                throw new Exception($"Строка запроса контента {requestString} уже существует.");

            var dataMethods = new List<DataMethodContent>();
            foreach (APIMethod method in methods)
                dataMethods.Add(new DataMethodContent(requestString, method));
            content.Add(requestString, dataMethods);
        }

        public void Remove(string requestString)
        {
            if(content.ContainsKey(requestString))
                content.Remove(requestString);
        }

        public DataMethodContent[] GetDataMethodContents(string requestString)
        {
            if (!content.ContainsKey(requestString))
                return null;

            return content[requestString].ToArray();
        }

        public void AddMethod(APIMethod method)
        {
            foreach (var item in content)
                item.Value.Add(new DataMethodContent(item.Key, method));
        }

        public void RemoveMethod(string method)
        {
            foreach (var list in content.Values)
                foreach (var item in list)
                    if (item.ApiMethod.Name == method)
                    {
                        list.Remove(item);
                        break;
                    }
        }

        public string[] PrepareForSerialization()
        {
            return content.Select(item => item.Key).ToArray();
        }
        #endregion
    }
}
