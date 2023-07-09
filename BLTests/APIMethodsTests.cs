using System;
using System.IO;
using System.Reflection;
using BL;
using Model;
using NUnit.Framework;

namespace BLTests
{
    [TestFixture]
    public class APIMethodsTests
    {
        [Test]
        public void APIMethodCreation()
        {
            var methodName = "method1";
            var data = new APIData(@"w:\");
            Assert.IsNull(data.GetAPIMethod(methodName));
            data.AddAPIMethod(methodName);
            Assert.IsNotNull(data.GetAPIMethod(methodName));
            Assert.AreEqual(methodName, data.GetAPIMethod(methodName).ToString());
            try
            {
                data.AddAPIMethod(methodName);
                throw new Exception("Не прошел тест на проверку дублей методов API");
            }
            catch (Exception ex)
            {
                Assert.AreEqual($"Метод с именем {methodName} уже существует", ex.Message);
            }
        }

        [Test]
        public void APIMethodsSerialization()
        {
            var methodName1 = "method1";
            var methodName2 = "method2";
            var methodName3 = "method3";
            var fileName = Path.Combine(Path.GetTempPath(), "APIMethods.json");
            File.Delete(fileName);
            var data = new APIData(Path.GetTempPath());
            data.AddAPIMethod(methodName1);
            data.AddAPIMethod(methodName2);
            data.SaveAPIMethods();
            if (!File.Exists(fileName))
                throw new Exception("Не удалось сериализовать APIMethods");

            var data2 = new APIData(Path.GetTempPath());
            Assert.IsNotNull(data.GetAPIMethod(methodName1));
            Assert.AreEqual(methodName1, data.GetAPIMethod(methodName1).ToString());
            Assert.IsNotNull(data.GetAPIMethod(methodName2));
            Assert.AreEqual(methodName2, data.GetAPIMethod(methodName2).ToString());
            Assert.IsNull(data.GetAPIMethod(methodName3));

            File.Delete(fileName);
        }
    }
}
