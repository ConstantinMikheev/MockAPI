using NUnit.Framework;
using System;
using System.Text.Json;
using System.IO;
using BL;

namespace BLTests
{
    [TestFixture]
    public class KeysTests
    {
        [Test]
        public void KeyCreation()
        {
            var methodName1 = "method1";
            var methodName2 = "method2";
            var methodName3 = "method3";
            var methodName4 = "method4";
            var data = new APIData(@"w:\");
            data.AddAPIMethod(methodName1);
            data.AddAPIMethod(methodName2);
            data.AddAPIMethod(methodName3);

            var keyId = "1234";
            var keyId2 = "12345";
            Assert.IsNull(data.GetKey(keyId));
            data.AddKey(keyId);
            data.AddKey(keyId2);
            var key = data.GetKey(keyId);
            Assert.IsNotNull(key);

            try
            {
                data.AddKey(keyId);
                throw new Exception("Не прошел тест на проверку дублей ключа");
            } catch (Exception ex)
            {
                Assert.AreEqual($"Ключ {keyId} уже существует", ex.Message);
            }

            var keyMethods = key.GetMethods();
            foreach (var method in keyMethods)
            {
                Assert.AreEqual(keyId, method.key);
                var methodName = method.ApiMethod;
                if (!(methodName == methodName1 || methodName == methodName2 || methodName == methodName3))
                    throw new Exception("У ключа НЕ найдены методы");
            }

            data.AddAPIMethod(methodName4);
            keyMethods = key.GetMethods();
            bool found =false;
            foreach (var method in keyMethods)
            {
                Assert.AreEqual(keyId, method.key);
                var methodName = method.ApiMethod;
                if (methodName == methodName4)
                    found = true;
            }
            if (!found)
                throw new Exception($"У ключа НЕ найден метод {methodName4}");

            data.RemoveAPIMethod(methodName4);
            keyMethods = key.GetMethods();
            found = false;
            foreach (var method in keyMethods)
            {
                Assert.AreEqual(keyId, method.key);
                var methodName = method.ApiMethod;
                if (methodName == methodName4)
                    found = true;
            }
            if (found)
                throw new Exception($"У ключа НАЙДЕН метод {methodName4}");

            data.RemoveKey(keyId2);
            Assert.IsNull(data.GetKey(keyId2), "Не удалось удалить ключ из списка");
        }

        [Test]
        public void KeysSerialization()
        {
            var path = Path.Combine(Path.GetTempPath(), "Keys.json");
            var path2 = Path.Combine(Path.GetTempPath(), "APIMethods.json");
            File.Delete(path);
            File.Delete(path2);
            var methodName1 = "method1";
            var methodName2 = "method2";
            var methodName3 = "method3";
            var data = new APIData(Path.GetTempPath());
            data.AddAPIMethod(methodName1);
            data.AddAPIMethod(methodName2);
            data.AddAPIMethod(methodName3);

            var keyId = "1234";
            data.AddKey(keyId);
            var key = data.GetKey(keyId);
            foreach (var item in key.methods)
            {
                if (item.Key == methodName1)
                    item.Value.TotalCount = 55;
                if (item.Key == methodName2)
                    item.Value.SpentCount = 45;
            }

            data.SaveKeys();
            if (!File.Exists(path))
                throw new Exception("Не удалось сериализовать Keys");

            var data2 = new APIData(Path.GetTempPath());

            key = data2.GetKey(keyId);
            Assert.IsNotNull(key);
            var keyMethods = key.GetMethods();
            foreach (var method in keyMethods)
            {
                Assert.AreEqual(keyId, method.key);
                var methodName = method.ApiMethod;
                if (!(methodName == methodName1 || methodName == methodName2 || methodName == methodName3))
                    throw new Exception("У ключа НЕ найдены методы");
                if (method.key == methodName1 && method.TotalCount != 55)
                    throw new Exception("Неверное количество общих запросов на ключе");
                if (method.key == methodName2 && method.SpentCount != 45)
                    throw new Exception("Неверное количество истраченных запросов на ключе");
            }

            File.Delete(path);
            File.Delete(path2);
        }
    }
}
