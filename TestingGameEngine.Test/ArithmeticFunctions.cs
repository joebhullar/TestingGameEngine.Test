using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingGameEngine.Test
{
    [TestClass]
    public class ArithmeticFunctions
    {
       [TestMethod]
        public void CheckForAddition()
        {
            var sut = new SimpleArithmetic();

            CollectionAssert.Contains(sut.ArithmeticFunctions, "Addition");
        
        }
        [TestMethod]
        public void CheckForMultiplication()
        {
            var sut = new SimpleArithmetic();

            CollectionAssert.Contains(sut.ArithmeticFunctions, "Multiplication");
        }

        [TestMethod]
        public void HaveAllExpectedArithmeticFunctionsInSameOrder()
        {
            var sut = new SimpleArithmetic();
            var expectedArithmeticFunctions = new[] { "Addition", "Subtraction", "Multiplication", "Division" };
            CollectionAssert.AreEqual(sut.ArithmeticFunctions, expectedArithmeticFunctions); //Order matters in List<string> comparison
        }
        [TestMethod]
        public void HaveAllExpectedArithmeticFunctions()
        {
            var sut = new SimpleArithmetic();
            var expectedArithmeticFunctions = new[] { "Addition", "Subtraction", "Division", "Multiplication" };
            CollectionAssert.AreEquivalent(sut.ArithmeticFunctions, expectedArithmeticFunctions); //Order DOES NOT matter in List<string> comparison
        }
        [TestMethod]
        public void HaveNoDuplicateFunctions()
        {
            var sut = new SimpleArithmetic();
            //comment below will introduce a duplication list item & fail the test
            //sut.ArithmeticFunctions.Add("Addition");
            CollectionAssert.AllItemsAreUnique(sut.ArithmeticFunctions);
        }

    }
}
