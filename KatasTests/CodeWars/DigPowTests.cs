using Katas.CodeWars;
using NUnit.Framework;

namespace KatasTests.CodeWars
{
    [TestFixture]
    public class DigPowTests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, DigPow.DigitPowers(89, 1));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(-1, DigPow.DigitPowers(92, 1));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(51, DigPow.DigitPowers(46288, 3));
        }
    }
}