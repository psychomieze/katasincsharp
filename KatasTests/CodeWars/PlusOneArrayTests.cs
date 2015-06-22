using Katas.CodeWars;
using NUnit.Framework;

namespace KatasTests.CodeWars
{
    public class PlusOneArrayTests
    {
        [Test]
        public void Test1()
        {
            int[] num = new int[] {2, 3, 9};
            int[] newNum = new int[] {2, 4, 0};
            Assert.AreEqual(newNum, PlusOneArray.UpArray(num));
        }

        [Test]
        public void Test2()
        {
            int[] num = new int[] {4, 3, 2, 5};
            int[] newNum = new int[] {4, 3, 2, 6};
            Assert.AreEqual(newNum, PlusOneArray.UpArray(num));
        }

        [Test]
        public void Test3()
        {
            int[] num = new int[] { 4, -3, 2, 5 };
            Assert.AreEqual(null, PlusOneArray.UpArray(num));
        }

        [Test]
        public void Test4()
        {
            int[] num = new int[] { 4, 3, 2, 9 };
            int[] newNum = new int[] { 4, 3, 3, 0 };
            Assert.AreEqual(newNum, PlusOneArray.UpArray(num));
        }

        [Test]
        public void Test5()
        {
            int[] num = new int[] { 9, 9, 9, 9 };
            int[] newNum = new int[] { 1, 0, 0, 0, 0 };
            Assert.AreEqual(newNum, PlusOneArray.UpArray(num));
        }
    }
}