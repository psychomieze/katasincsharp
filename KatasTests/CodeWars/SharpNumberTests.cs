using Katas.CodeWars;
using NUnit.Framework;

namespace KatasTests.CodeWars
{
    [TestFixture]
    public class SharpNumberTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, SharpNumber.FindSharpNumber(new int[] { 1, 3, 3, 3, 1 }));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, SharpNumber.FindSharpNumber(new int[] { 1, 3, 2, 1 }));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(1, SharpNumber.FindSharpNumber(new int[] { 1, 3, -1, 2, -1, 0, 1 }));
        }
    
    }
}