using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestingGameEngine.Test
{
    [TestClass]
    public class TestingFactorialValues
    {
        public string factorialValue = "7";

        [TestMethod]
        public void SevenFactorialValue()
        {
            FirstFactorial sut = new FirstFactorial();
            int v = sut.getFirstFactorial(factorialValue);

            Assert.AreEqual(5040,v);
        }
    }
}
