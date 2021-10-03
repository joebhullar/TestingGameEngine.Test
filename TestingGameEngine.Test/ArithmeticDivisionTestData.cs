using System;
using System.Collections.Generic;
using System.Text;

namespace TestingGameEngine.Test
{
    public class ArithmeticDivisionTestData
    {
        public static IEnumerable<object[]> GetDivisionDeltaValues()
        {

            return new List<object[]>
                {
                    new object[] { "3", "500"},
                    new object[] { "0.3", "50"},
                    new object[] { "0.03", "5"},
                    new object[] { "0.003", "0.5"},
                };

        }
    }
}
