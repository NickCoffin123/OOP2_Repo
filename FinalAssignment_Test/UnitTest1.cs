/* 
 * Nick Coffin - 100555045
 * Final Assignment - AI in programming
 * December 2024
 * Testing file
 */
using FinalAssignment.Classes;
using FinalAssignment.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FinalAssignment;

namespace FinalAssignment_Test
{
    /// <summary>
    /// Tests for the Utilities class
    /// Chat GPT was down and Co pilot did not give any suggestions
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_BMI_01()
        {
            double excepted = 20;
            double actual = Utilities.CalculateBMI(65, 1.8);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void TestMethod1_BMI_02()
        {
            double excepted = 27;
            double actual = Utilities.CalculateBMI(65, 1.55);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void TestMethod1_BMI_03()
        {
            double excepted = 200;
            double actual = Utilities.CalculateBMI(200, 1);
            Assert.AreEqual(excepted, actual);
        }
    }
}
