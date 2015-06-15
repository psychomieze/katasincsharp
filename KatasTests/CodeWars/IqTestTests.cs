using Katas.CodeWars;
using NUnit.Framework;

namespace KatasTests.CodeWars
{
    public class IqTestTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, IqTest.Test("2 4 7 8 10"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, IqTest.Test("1 2 2"));
        }
    }
}