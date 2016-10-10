using FizzBuzzWithUnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzWithUnitTest.Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void GetResult_Should_Be_Fizz_If_Number_Division_On_3_By_Module()
        {
            //arrange

            int i = 3;
            string expected = "Fizz";

            //act

            string result = Program.GetResult(i);

            //assert

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void GetResult_Should_Be_Buzz_If_Number_Division_On_5_By_Module()
        {
            //arrange

            int i = 5;
            string expected = "Buzz";

            //act

            string result = Program.GetResult(i);

            //assert

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void GetResult_Should_Be_FizzBuzz_If_Number_Division_On_15_By_Module()
        {
            //arrange

            int i = 15;
            string expected = "FizzBuzz";

            //act

            string result = Program.GetResult(i);

            //assert

            Assert.AreEqual(expected, result);

        }
    }
}
