using Katas.CodeWars;
using NUnit.Framework;

namespace KatasTests.CodeWars
{
    public class PalindromeChainTests
    {
        [Test]
        public void Given87OutputShouldBe4()
        {
            Assert.AreEqual(4, PalindromeChain.PalindromeChainLength(87));
        }
    }
}