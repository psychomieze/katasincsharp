using Katas.CodeWars;
using NUnit.Framework;

namespace KatasTests.CodeWars
{
    public class TwistedSumTests
    {
        [Test]
        public void When03_Then6()
        {
            Assert.AreEqual(6, TwistedSum.Solution(3));
        }
        [Test]
        public void When10_Then46()
        {
            Assert.AreEqual(46, TwistedSum.Solution(10));
        }
        [Test]
        public void When11_Then48()
        {
            Assert.AreEqual(48, TwistedSum.Solution(11));
        }
        [Test]
        public void When12_Then51()
        {
            Assert.AreEqual(51, TwistedSum.Solution(12));
        }
        [Test]
        public void When_Then51()
        {
            Assert.AreEqual(51, TwistedSum.Solution(23));
        }
        [Test]
        public void When100_Then51()
        {
            Assert.AreEqual(1038, TwistedSum.Solution(123));
        }
    }
}