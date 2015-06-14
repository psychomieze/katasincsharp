using Katas.CodeWars;
using NUnit.Framework;

namespace KatasTests.CodeWars
{
    public class AreTheySameTests
    {
        [Test]
        public void Test1()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = AreTheySame.Comp(a, b); // True
            Assert.AreEqual(true, r);
        }

        [Test]
        public void Test2()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 10, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = AreTheySame.Comp(a, b); 
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test3()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] {  };
            bool r = AreTheySame.Comp(a, b);
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test4()
        {
            int[] a = new int[] { };
            int[] b = new int[] { 123 };
            bool r = AreTheySame.Comp(a, b);
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test5()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 18 * 18 };
            bool r = AreTheySame.Comp(a, b);
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test6()
        {
            int[] a = new int[] { };
            int[] b = null;
            bool r = AreTheySame.Comp(a, b);
            Assert.AreEqual(false, r);
        }

        [Test]
        public void Test7()
        {
            int[] a = new int[] { 123 };
            int[] b = new int[] { };
            bool r = AreTheySame.Comp(a, b);
            Assert.AreEqual(false, r);
        }
    }
}