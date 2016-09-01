using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChromeTest;

namespace AutoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var tt = new Class1();
            tt.start_browser();

        }
    }
}
