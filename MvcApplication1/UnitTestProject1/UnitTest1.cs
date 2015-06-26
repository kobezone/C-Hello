using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var pm = new PostModel {IsExpert = true};
            Console.WriteLine(pm.IsExpert);
        }
    }
}
