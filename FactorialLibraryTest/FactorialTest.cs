using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static FactorialLibrary.Factorial;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace FactorialLibraryTest
{
    [TestClass]
    public class FactorialTest
    {
        [TestMethod]
        public void ValidationNaturalNumber_24_ReturnedTrue()
        {
            //arrange
            int number = 24;
            bool expected = true;

            //act
            bool actual = ValidationNaturalNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidationNaturalNumber_Minus55_ReturnedFalse()
        {
            //arrange
            int number = -55;
            bool expected = false;

            //act
            bool actual = ValidationNaturalNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFactorial_5_Returned120()
        {
            //arrange
            int number = 5;
            long expected = 120;

            //act
            long actual = CalculateFactorial(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFactorial_1_Returned1()
        {
            //arrange
            int number = 1;
            long expected = 1;

            //act
            long actual = CalculateFactorial(number);

            //assert
            AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void CalculateFactorial_0_ValidationException()
        {
            //arrange
            int number = 0;

            //act + assert
            CalculateFactorial(number);
        }
    }
}