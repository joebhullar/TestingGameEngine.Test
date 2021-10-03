using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingGameEngine.Test
{  
    [TestClass]
    public class Lifecycle
    {
        [ClassInitialize] // This filter will make this method execute FIRST!
        public static void ClassInitialize() //must be static method for ClassInitialize attribute
        {
            Console.WriteLine("  ClassInitialize Lifecycle - this will execute as the first method  in list of functions in LifeCycle class.");
        }

        [TestInitialize] // This filter will make this method execute FIRST!
        public void LifecycleInit()
        {
            Console.WriteLine("  Test Initialize Lifecycle - this method wille execute before each testcase");
        }
        [TestCleanup] // This Filter-Attribute instructs TestRunner to run this attribute after each & every test
        public void LifecycleClean()
        {
            Console.WriteLine("  Test Initialize Lifecycle - this method wille execute after each testcase");
        }
        [TestMethod]
        public void TestA()
        {
            Console.WriteLine("  Test A Starting");
        }
        [TestMethod]
        public void TestB()
        {
            Console.WriteLine("  Test B Starting");
        }
        [ClassCleanup] //Attribute tells TestRunner to execute this method below after last test in test class has excecuted. 
        public void LifeCycleClassClean()
        {
            Console.WriteLine("  ClassCleanup Lifecycle");
        }

    }
}
