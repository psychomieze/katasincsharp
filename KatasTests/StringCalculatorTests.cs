#region

using System;
using Katas;
using NUnit.Framework;

#endregion

namespace KatasTests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [SetUp]
        public void SetUp()
        {
            stringCalculator = new StringCalculator();
        }

        private StringCalculator stringCalculator;

        [Test]
        public void AddReturnsNumberAsIntIfOneNumberGiven()
        {
            var returnNumber = stringCalculator.Add("3");
            Assert.AreEqual(3, returnNumber);
        }

        [Test]
        public void AddReturnsSumOfNumbersForNumbersSeparatedByBothNewLineAndComma()
        {
            int ret = stringCalculator.Add("2\n3,5");
            Assert.AreEqual(10, ret);
        }

        [Test]
        public void AddReturnsSumOfNumbersForNumbersSeparatedByGivenDelimiter()
        {
            int ret = stringCalculator.Add("//;\n1;3");
            Assert.AreEqual(4, ret);
        }

        [Test]
        public void AddReturnsSumOfNumbersForTwoNumber()
        {
            int ret = stringCalculator.Add("2,3");
            Assert.AreEqual(5, ret);
        }

        [Test]
        public void AddReturnsZeroForEmptyString()
        {
            int returnNumber = stringCalculator.Add(string.Empty);
            Assert.AreEqual(0, returnNumber);
        }

        [Test]
        public void AddThrowsExceptionOnMultipleNegatiesAndReturnsExceptionMessageWithAllOfThem()
        {
            Assert.That(
                () => stringCalculator.Add("2,-3, -5"),
                Throws.TypeOf<Exception>().With.Message.ContainsSubstring("-3").And.Message.ContainsSubstring("-5")
                );
        }

        [Test]
        public void AddThrowsExceptionOnNegativeNumber()
        {
            Assert.That(() => stringCalculator.Add("2,-3"), Throws.TypeOf<Exception>().With.Message.Contains("-3"));
        }

        [Test]
        public void AddIgnoresNumbersBiggerThanThousand()
        {
            int returnNumber = stringCalculator.Add("2,1001");
            Assert.AreEqual(2, returnNumber);
        }

        [Test]
        public void AddAllowsDelimitersOfAnyLength()
        {
            int returnNumber = stringCalculator.Add("//[***]\n1***2***3");
            Assert.AreEqual(6, returnNumber);
        }

        [Test]
        public void AddAllowsMultipleDelimiters()
        {
            int returnNumber = stringCalculator.Add("//[**][...]\n1**2...3");
            Assert.AreEqual(6, returnNumber);
        }
    }
}