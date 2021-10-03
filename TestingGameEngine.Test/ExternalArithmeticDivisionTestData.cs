using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestingGameEngine.Test
{
    public class ExternalArithmeticDivisionTestData
    {
        public static IEnumerable<object[]> TestData
        {
            get 
            {
                string[] csvLines = File.ReadAllLines("ArithmeticDivisionData.csv"); //Capture all String values 

                List<string[]> testCases = new List<string[]>(); // Create String Array List

                foreach (var csvLine in csvLines)
                {
                    IEnumerable<string> values = csvLine.Split(','); //identify all strings by delimiter ','
                    string[] testCase = values.Cast<string>().ToArray(); //create arrau pf string & put string into array
                    testCases.Add(testCase);
                }

                return testCases;
            }
        }
    }
}
