using Katas.CodeWars;
using NUnit.Framework;

namespace KatasTests.CodeWars
{
    public class DoubleColaTests
    {
        [Test]
        public void Test1()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 1;
            Assert.AreEqual("Sheldon", DoubleCola.WhoIsNext(names, n));
        }

        [Test]
        public void Test2()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 6;
            Assert.AreEqual("Sheldon", DoubleCola.WhoIsNext(names, n));
        }

        [Test]
        public void Test3()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 12;
            Assert.AreEqual("Rajesh", DoubleCola.WhoIsNext(names, n));
        }

        [Test]
        public void Test6()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 10;
            Assert.AreEqual("Penny", DoubleCola.WhoIsNext(names, n));
        }

        [Test]
        public void Test4()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 63;
            Assert.AreEqual("Rajesh", DoubleCola.WhoIsNext(names, n));
        }

        [Test]
        public void Test5()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 3667;
            Assert.AreEqual("Penny", DoubleCola.WhoIsNext(names, n));
        }
    }
}