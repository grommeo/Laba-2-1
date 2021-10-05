using Microsoft.VisualStudio.TestTools.UnitTesting;
using Лаба_2_1_Сsh;
using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_2_1_Сsh.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void RubCopTest1()
        {
            var n = 1233;

            var Out = Logic.RubCop(n);

            Assert.AreEqual("12 Рублей  33 Копейки", Out);
        }
        [TestMethod()]
        public void RubCopTest2()
        {
            var n = 1200;

            var Out = Logic.RubCop(n);

            Assert.AreEqual("12 Рублей   ", Out);
        }
        [TestMethod()]
        public void RubCopTest3()
        {
            var n = 100;

            var Out = Logic.RubCop(n);

            Assert.AreEqual("1 Рубль   ", Out);
        }
        [TestMethod()]
        public void RubCopTest4()
        {
            var n = 200;

            var Out = Logic.RubCop(n);

            Assert.AreEqual("2 Рубля   ", Out);
        }
        [TestMethod()]
        public void RubCopTest5()
        {
            var n = 2800;

            var Out = Logic.RubCop(n);

            Assert.AreEqual("28 Рублей   ", Out);
        }
        [TestMethod()]
        public void RubCopTest6()
        {
            var n = 21;

            var Out = Logic.RubCop(n);

            Assert.AreEqual(" 21 Копейка", Out);
        }
        [TestMethod()]
        public void RubCopTest7()
        {
            var n = 33;

            var Out = Logic.RubCop(n);

            Assert.AreEqual(" 33 Копейки", Out);
        }
        [TestMethod()]
        public void RubCopTest8()
        {
            var n = 45;

            var Out = Logic.RubCop(n);

            Assert.AreEqual(" 45 Копеек", Out);
        }
        [TestMethod()]
        public void RubCopTest9()
        {
            var n = 99892;

            var Out = Logic.RubCop(n);

            Assert.AreEqual("Ошибка. Некорректный ввод", Out);
        }
        
    }
}