using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class APIMethods: IEnumerable
    {
        private Dictionary<string, APIMethod> methods;

        #region Constructors
        public APIMethods()
        {
            methods = new Dictionary<string, APIMethod>();
        }

        public APIMethods(APIMethod[] arrayOfMethods)
        {
            methods = new Dictionary<string, APIMethod>();

            foreach(var item in arrayOfMethods)
                methods[item.Name] = item;
        }
        #endregion

        #region Interface realisation
        public IEnumerator GetEnumerator()
        {
            foreach(var method in methods.Values)
                yield return method;
        }
        #endregion

        #region Other methods
        public void Add(string method)
        {
            var newMethod = new APIMethod(method);
            Add(newMethod);
        }

        public void Add(APIMethod method)
        {
            var name = method.Name.ToLower();

            if (methods.ContainsKey(name))
                throw new Exception($"Метод с именем {name} уже существует");

            methods.Add(name, method);
        }

        public void Remove(string method)
        {
            if (methods.ContainsKey(method.ToLower()))
                methods.Remove(method.ToLower());
        }

        public void Remove(APIMethod method)
        {
            Remove(method.Name);
        }

        public APIMethod GetMethod(string name)
        {
            if (methods.ContainsKey(name))
                return methods[name];
            return null;
        }

        public APIMethod[] PrepareForSerialization()
        {
            return methods.Values.ToArray();
        }
        #endregion
    }
}
