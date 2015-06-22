using Katas.CodeWars;
using NUnit.Framework;

namespace KatasTests.CodeWars
{
    public class StringSumsTests
    {
        [TestCase("3", "5", "8")]
        [TestCase("5", "5", "10")]
        [TestCase("3", "15", "18")]
        [TestCase("33", "66", "99")]
        [TestCase("40", "66", "106")]
        [TestCase("45", "66", "111")]
        public void Calculates(string a, string b, string sum) 
        {
            Assert.AreEqual(sum, StringSums.SumStrings(a, b));
        }

        [Test]
        public void Given123And456Returns579()
        {
            Assert.AreEqual("579", StringSums.SumStrings("123", "456"));
        }
    }
}