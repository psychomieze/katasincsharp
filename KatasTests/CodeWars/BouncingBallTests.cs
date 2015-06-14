using Katas.CodeWars;
using NUnit.Framework;

namespace KatasTests.CodeWars
{
    public class BouncingBallTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, BouncingBall.bouncingBall(3.0, 0.66, 1.5));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(15, BouncingBall.bouncingBall(30.0, 0.66, 1.5));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(-1, BouncingBall.bouncingBall(3, 1, 1.5));
        }
    }
}