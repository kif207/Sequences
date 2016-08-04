using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MSTestHacks;
using Common.Helpers;

namespace UnitTests.SequenceHelperTests
{
    [TestClass]
    public class AllNumbersUnitTests : TestBase
    {
        
        [TestMethod]
        public void Given_A_NegativeInput_AllNumbers_Returns_EmptyList()
        {
            List<int> sequence = SequenceHelper.AllNumbers(-1);
            Assert.AreEqual(0, sequence.Count);
        }

        [TestMethod]
        public void Given_Zero_As_Input_AllNumbers_Returns_List_Only_Having_Zero()
        {
            List<int> actual = SequenceHelper.AllNumbers(0);
            List<int> expected = new List<int> { 0 };
            CollectionAssert.AreEqual(expected, actual);
        }

        /*
            Using https://github.com/Thwaitesy/MSTestHacks for runtime data driven tests
            where data is returned by a class metheod as an IEnumerable
        */

        /// <summary>
        /// This test method uses MSTestHacks features to iterate over list of test values         
        /// </summary>
        [TestMethod]
        [DataSource("UnitTests.SequenceHelperTests.AllNumbersUnitTests.AllNumbersTestValues")]
        public void Given_Positve_Whole_Number_AllNumbers_Returns_Numbers_UpTo_And_including_passed_value()
        {
            var value = this.TestContext.GetRuntimeDataSourceObject<dynamic>();
            string actual = String.Join(",", SequenceHelper.AllNumbers((int)value.number));
            string expected = (string)value.sequence;

            Assert.AreEqual(expected, actual,
                            "Failed for number={0} and sequence: \"{{{1}}}\" ).", value.number, value.sequence);

        }

        /// <summary>
        /// Returns a list of Test values to be used for AllNumbers. Each entry contains
        ///     1 - Number to be passed
        ///     2 - Numeric sequence expected
        /// </summary>
        private IEnumerable<dynamic> AllNumbersTestValues
        {
            get
            {
                return new List<dynamic> {          
                        new { number = 0 , sequence = "0" } ,                                            
                        new { number = 1 , sequence = "0,1" } ,
                        new { number = 2 , sequence = "0,1,2" } ,
                        new { number = 3 , sequence = "0,1,2,3" } ,
                        new { number = 4 , sequence = "0,1,2,3,4" } ,
                        new { number = 5 , sequence = "0,1,2,3,4,5" } ,
                        new { number = 6 , sequence = "0,1,2,3,4,5,6" } ,
                        new { number = 7 , sequence = "0,1,2,3,4,5,6,7" } ,
                        new { number = 8 , sequence = "0,1,2,3,4,5,6,7,8" } ,
                        new { number = 9 , sequence = "0,1,2,3,4,5,6,7,8,9" } ,
                        new { number = 10 , sequence = "0,1,2,3,4,5,6,7,8,9,10" } ,
                        new { number = 11 , sequence = "0,1,2,3,4,5,6,7,8,9,10,11" } ,
                        new { number = 12 , sequence = "0,1,2,3,4,5,6,7,8,9,10,11,12" } ,
                        new { number = 13 , sequence = "0,1,2,3,4,5,6,7,8,9,10,11,12,13" } ,
                        new { number = 14 , sequence = "0,1,2,3,4,5,6,7,8,9,10,11,12,13,14" } ,
                        new { number = 15 , sequence = "0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15" } ,
                        new { number = 16 , sequence = "0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16" } ,
                        new { number = 17 , sequence = "0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17" } ,
                        new { number = 18 , sequence = "0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18" } ,
                        new { number = 19 , sequence = "0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19" } ,
                        new { number = 20 , sequence = "0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20" } 
                    };
            }
        }
    }
}
