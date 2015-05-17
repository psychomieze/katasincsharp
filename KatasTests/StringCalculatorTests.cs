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
        [Test]
        public void AddReturnsZeroForEmptyString()
        {
            int sum = StringCalculator.Add("");
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void AddReturnsNumberAsIntForOneNumber()
        {
            int sum = StringCalculator.Add("3");
            Assert.AreEqual(3, sum);
        }

        [Test]
        public void AddReturnsSumForMultipleNumbers()
        {
            int sum = StringCalculator.Add("3,5");
            Assert.AreEqual(8, sum);
        }

        [Test]
        public void AddAllowsNewlineAsDelimiter()
        {
            int sum = StringCalculator.Add("1\n2,3");
            Assert.AreEqual(6, sum);
        }

        [Test]
        public void AddAllowsDefinitionOfDelimiter()
        {
            int sum = StringCalculator.Add("//;\n1;2");
            Assert.AreEqual(3, sum);
        }

        [Test]
        public void AddThrowsExceptionWhenGivenNegativeNumbers() 
        {
            Assert.That(() => StringCalculator.Add("3,-3,-4"), Throws.Exception.With.Message.ContainsSubstring("-3,-4"));
        }

        [Test]
        public void AddIgnoresNumbersBiggerThanThousand()
        {
            int sum = StringCalculator.Add("3,1001");
            Assert.AreEqual(3, sum);
        }

        [Test]
        public void AddAllowsDelimitersOfAnyLength()
        {
            int sum = StringCalculator.Add("//[***]\n1***2***3");
            Assert.AreEqual(6, sum);
        }

        [Test]
        public void AddAllowsMultipleDelimiters()
        {
            int sum = StringCalculator.Add("//[**][%]\n1**2%3");
            Assert.AreEqual(6, sum);
        }
    }
}