using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        public int Add(int a,int b)
        {
            int c = 0;
            c =  a + b;
            return c;
        }
    }
}
