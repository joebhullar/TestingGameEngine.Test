using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FirstFactorial
    {
        public int getFirstFactorial(string v)
        {
            int n = int.Parse(v);

            // code goes here
            int res = 1;
            while (n != 1)
            {
                res = res * n;
                n = n - 1;
            }
            return res;
        }

        public bool greaterThan1000(int value) 
        { 
            if(value > 1000)
            { return true; }
            return false;
        }

        public bool greaterThan3000(int value)
        {
            if (value > 3000)
            { return true; }
            return false;
        }
    }

}
