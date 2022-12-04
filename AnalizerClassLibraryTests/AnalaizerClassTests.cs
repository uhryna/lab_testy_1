using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using AnalaizerClassLibrary;

namespace AnalizerClassLibrary.Tests
{
    [TestClass]
    public class AnalaizerClassTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                    "testData.xml",
                    "Test", DataAccessMethod.Sequential)]
        public void CheckCurrencyTest()
        {
            //Arrange
            AnalaizerClass.expression = Convert.ToString(TestContext.DataRow["expression"]); // витягуємо дані з xml файлу
            bool expected = Convert.ToBoolean(TestContext.DataRow["expected"]);

            //Act
            bool result = AnalaizerClass.CheckCurrency(); // викликаємо метод для тестування

            Assert.AreEqual(result, expected); // порівнюємо результат та очікуване значення
        }
    }
}
