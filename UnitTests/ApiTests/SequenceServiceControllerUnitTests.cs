using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web.Controllers;

namespace UnitTests.ApiTests
{
    [TestClass]
    public class SequenceServiceControllerUnitTests
    {
        static SequenceServiceController controller;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            controller = new SequenceServiceController();
        }

        [TestMethod]
        public void WebAPI_GetAllNumbers_Returns_Numbers_UpTo_And_including_passed_value_When_Passed_Positve_Whole_Number()
        {
            string actual = controller.GetAllNumbers(5);
            string expected = "0,1,2,3,4,5";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WebAPI_GetAllOddNumbers_Returns_Odd_Numbers_UpTo_And_including_passed_value_When_Passed_Positve_Whole_Number()
        {
            string actual = controller.GetAllOddNumbers(10);
            string expected = "1,3,5,7,9";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WebAPI_GetAllEvenNumbers_Returns_Even_Numbers_UpTo_And_including_passed_value_When_Passed_Positve_Whole_Number()
        {
            string actual = controller.GetAllEvenNumbers(10);
            string expected = "0,2,4,6,8,10";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WebAPI_GetCEZSequence_Returns_Numbers_UpTo_And_including_passed_value_with_CEZ_Replacements_When_Passed_Positve_Whole_Number()
        {
            string actual = controller.GetCEZSequence(16);
            string expected = "0,1,2,C,4,E,C,7,8,C,E,11,C,13,14,Z,16";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WebAPI_GetFibonacciNumbers_Returns_Fibonacci_Numbers_UpTo_And_including_passed_value_When_Passed_Positve_Whole_Number()
        {
            string actual = controller.GetFibonacciNumbers(14);
            string expected = "0,1,1,2,3,5,8,13";

            Assert.AreEqual(expected, actual);
        }

    }
}
