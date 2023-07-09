using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
    public class Keys: IEnumerable
    {
        private Dictionary<string, Key> keys;

        #region Constructors
        public Keys()
        {
            keys = new Dictionary<string, Key>();
        }

        public Keys(List<KeyMethod[]> keysList): this()
        {
            foreach (var keyMethods in keysList)
            {
                foreach (var method in keyMethods)
                {
                    if (!keys.ContainsKey(method.key))
                        keys.Add(method.key, new Key(method.key));
                    keys[method.key].methods.Add(method.ApiMethod, method);
                }
            }
        }
        #endregion

        #region Other methods
        /// <summary>
        /// Добавляет ключ в список
        /// </summary>
        /// <param name="key"></param>
        /// <exception cref="Exception"></exception>
        public void Add(string key)
        {
            if (keys.ContainsKey(key))
                throw new Exception($"Ключ {key} уже существует");
            keys.Add(key, new Key(key));
        }

        /// <summary>
        /// Добавляет ключ в список
        /// </summary>
        /// <param name="key"></param>
        /// <param name="methods"></param>
        /// <exception cref="Exception"></exception>
        public void Add(string key, APIMethods methods)
        {
            if (keys.ContainsKey(key))
                throw new Exception($"Ключ {key} уже существует");
            keys.Add(key, new Key(key, methods));
        }

        public void Remove(string key)
        {
            if(keys.ContainsKey(key))
                keys.Remove(key);
        }

        public void Remove(Key key)
        {
            Remove(key.Id);
        }

        public Key GetKey(string id)
        {
            if (!keys.ContainsKey(id))
                return null;

            return keys[id];
        }

        /// <summary>
        /// Список методов API, подключенных к ключу
        /// </summary>
        /// <param name="key">Строковый идентифиактор ключа</param>
        /// <returns></returns>
        public KeyMethod[] GetKeyMethods(string key)
        {
            if (!keys.ContainsKey(key))
                return null;

            return keys[key].GetMethods();
        }

        public List<KeyMethod[]> PrepareForSerialization()
        {
            var result = new List<KeyMethod[]>();
            foreach (var key in keys.Values)
                result.Add(key.GetMethods());

            return result;
        }
        #endregion

        #region Interface realisation
        public IEnumerator GetEnumerator()
        {
            foreach(var item  in keys.Values)
                yield return item;
        }
        #endregion
    }
}
