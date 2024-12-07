using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Week13DemoB;

namespace Week12DemoB_Test
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod_FtoC_01()
        {
            decimal expected = 0;
            decimal actual = Tools.ConvertFtoC(32);
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void TestMethod_FtoC_02()
        //{
        //    decimal expected = 100;
        //    decimal
        //}

        [TestMethod]
        public void TestMethod_FtoC_03()
        {
            decimal expected = -10.28m;
            decimal actual = Tools.ConvertFtoC(13.5m);
            Assert.AreEqual(expected, actual);
        }
    }
}
