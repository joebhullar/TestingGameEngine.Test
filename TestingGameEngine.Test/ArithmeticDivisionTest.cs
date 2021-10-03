using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace TestingGameEngine.Test
{
    [TestClass]
    public class ArithmeticDivisionTest
    {
        [TestMethod]
        public void Divide1000BySix()
        {
            SimpleArithmetic sut = new SimpleArithmetic();
            double v = sut.DivideTwoDoubles("6", "1000");

            Assert.AreEqual(166.6, v, 0.07); // 3rd paramater is delta because 1000/6 is 166.6666666 we have delta for double value of acceptance 
        }
        [DataTestMethod]
        [DataRow("6","1000")]//DataRow lets us pass one or more data paramaters that can get passed for the test
        [DataRow("0.6", "100")]
        [DataRow("0.06", "10")]
        [DataRow("0.006", "1")]
        public void DivideTwoNumbers(string denominator, string numerator)
        {
            SimpleArithmetic sut = new SimpleArithmetic();
            double v = sut.DivideTwoDoubles(denominator, numerator);

            Assert.AreEqual(166.6, v, 0.07); // 3rd paramater is delta because 1000/6 is 166.6666666 we have delta for double value of acceptance 
        }


        [DataTestMethod]
        //[DynamicData(nameof(GetDivisionDeltaValues), DynamicDataSourceType.Method)]
        //[DynamicData(nameof(ArithmeticDivisionTestData.GetDivisionDeltaValues),
        //             typeof(ArithmeticDivisionTestData),
        //             DynamicDataSourceType.Method)]
        [DynamicData(nameof(ExternalArithmeticDivisionTestData.TestData),
                     typeof(ExternalArithmeticDivisionTestData))]
        public void DivideTwoNumbersVTWO(string denominator, string numerator)
        {
            SimpleArithmetic sut = new SimpleArithmetic();
            double v = sut.DivideTwoDoubles(denominator, numerator);

            Assert.AreEqual(166.6, v, 0.07); // 3rd paramater is delta because 1000/6 is 166.6666666 we have delta for double value of acceptance 
        }

    }
}
