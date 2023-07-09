using System.Collections;
using System.Collections.Generic;

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
        public void AddDataMethodContent(string requestString)
        {
            content.Add(requestString, new List<DataMethodContent>());
        }

        public void AddDataMethodContent(string requestString, APIMethods methods)
        {
            var dataMethods = new List<DataMethodContent>();
            foreach (APIMethod method in methods)
                dataMethods.Add(new DataMethodContent(requestString, method));
            content.Add(requestString, dataMethods);
        }

        public DataMethodContent[] GetDataMethodContents(string requestString)
        {
            if (!content.ContainsKey(requestString))
                return null;

            return content[requestString].ToArray();
        }

        public List<DataMethodContent>[] PrepareForSerialization()
        {
            var result = new List<List<DataMethodContent>>();
            foreach (var item in content.Values)
                result.Add(item);

            return result.ToArray();
        }
        #endregion
    }
}
