using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingGameEngine.Test
{
    [TestClass]
    public class FactorialGreaterThan
    {
        public string factorialValue = "7";
        [TestMethod]
        public void GreaterThan1000()
        {
            FirstFactorial sut = new FirstFactorial();
            int v = sut.getFirstFactorial(factorialValue);
            Assert.IsTrue(sut.greaterThan1000(v));
        }

        [TestMethod]
        public void GreaterThan3000()
        {
            FirstFactorial sut = new FirstFactorial();
            int v = sut.getFirstFactorial(factorialValue);
            Assert.IsTrue(sut.greaterThan3000(v));
        }
    }
}
