using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    /// <summary>
    /// Ключ доступа к API
    /// </summary>
    public class Key
    {
        #region Properties
        /// <summary>
        /// Идентификатор ключа (сам ключ)
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Срок действия ключа
        /// </summary>
        public DateTime expareDate { get; set; }
        /// <summary>
        /// Список методов API, подключенных к ключу
        /// </summary>
        public Dictionary<string, KeyMethod> methods { get; }
        #endregion

        #region Constructors
        public Key(string id)
        {
            Id = id;
            methods = new Dictionary<string, KeyMethod>();
        }

        public Key(string id, APIMethods apiMethods): this(id)
        {
            foreach (var item in apiMethods)
            {
                var apiMethod = item as APIMethod;
                var keyMethod = new KeyMethod(id, apiMethod.Name);
                methods.Add(apiMethod.Name, keyMethod);
            }
        }
        #endregion

        #region Other methods
        /// <summary>
        /// Список методов API, подключенных к ключу
        /// </summary>
        /// <returns>Массив свойств методов</returns>
        public KeyMethod[] GetMethods()
        {
            return methods.Values.ToArray();
        }

        public void AddMethod(string method)
        {
            methods.Add(method, new KeyMethod(Id, method));
        }

        public void RemoveMethod(string method)
        {
            if (methods.ContainsKey(method))
                methods.Remove(method);
        }
        #endregion
    }
}
