using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TenkeumiaffoSL.Sprint0.Task2.V0.Lib; 

namespace Tyuiu.TenkeumiaffoSL.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValide()
        {
            // область создания методов тестирования, методов из библиотеки
            var name = "Samuel";
            var res = DataService.GetMessage(name);

            // Вызываем класс Аssert и метод AreEqual
            Assert.AreEqual("hello..., Samuel", res);

        }
    }
}
