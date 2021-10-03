using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingGameEngine.Test
{
    [TestClass]
    public class Assembly
    {
        [AssemblyInitialize] //This attribute will execute Before ANY of the test methods execute. It will execute once TestGameEngine.Test is initalized.
        public static void AssemblyInit(TestContext context)
        {
            Console.WriteLine("AssemblyInit ");
        }

        [AssemblyCleanup] //This attribute will execute After ALL test methods execute. It will execute once TestGameEngine.Tests have been executed.
        public static void AssemblyClean()
        {
            Console.WriteLine("AssemblyClean");
        }

    }
}
