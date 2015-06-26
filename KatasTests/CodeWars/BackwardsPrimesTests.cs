using Katas.CodeWars;
using NUnit.Framework;

namespace KatasTests.CodeWars
{
    public class BackwardsPrimesTests
    {
        [Test]
        public void Test13()
        {
            string backwardsPrime = BackwardsPrimes.backwardsPrime(1, 100);
            Assert.AreEqual("13 17 31 37 71 73 79 97", backwardsPrime);
        }
        [Test]
        public void Test21()
        {
            Assert.AreEqual("9923 9931 9941 9967", BackwardsPrimes.backwardsPrime(9900, 10000));
        }
    }
}