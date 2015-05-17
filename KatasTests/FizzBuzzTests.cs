using System.Collections.Generic;
using Katas;
using NUnit.Framework;

namespace KatasTests
{
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void FizzBuzzReturnsFizzForNumberDivisibleByThree(int number)
        {
            string returnValue = _fizzBuzz.FizzBuzzMe(number);
            Assert.AreEqual("Fizz", returnValue);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(25)]
        [TestCase(20)]
        public void FizzBuzzMeReturnsBuzzForNumberDivisibleByFive(int number)
        {
            string returnValue = _fizzBuzz.FizzBuzzMe(number);
            Assert.AreEqual("Buzz", returnValue);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(8)]
        public void FizzBuzzMeReturnsNumberAsStringIfNeitherDivisibleThroughThreeNorFive(int number)
        {
            string returnValue = _fizzBuzz.FizzBuzzMe(number);
            Assert.AreEqual(number.ToString(), returnValue);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void FizzBuzzMeReturnsFizzBuzzForNumbersBothDivisibleByThreeAndFive(int number)
        {
            string returnValue = _fizzBuzz.FizzBuzzMe(number);
            Assert.AreEqual("FizzBuzz", returnValue);
        }

        [Test]
        public void GetListReturnsFizzBuzzedListUpToMax()
        {
            List<string> expectedList = new List<string>
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz",
            };
            int max = 15;
            List<string> returnedList = _fizzBuzz.GetList(max);
            Assert.AreEqual(expectedList, returnedList);
        }
    }
}