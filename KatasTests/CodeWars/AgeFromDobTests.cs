using System;
using Katas.CodeWars;
using NUnit.Framework;

namespace KatasTests.CodeWars
{
    public class AgeFromDobTests
    {
        private AgeFromDob kata;

        [Test]
        public void SystemClock_IsEqualWithDateTimeNow()
        {
            Assert.AreEqual(DateTime.Now.Year, new SystemClock().Now.Year);
            Assert.AreEqual(DateTime.Now.Month, new SystemClock().Now.Month);
            Assert.AreEqual(DateTime.Now.Day, new SystemClock().Now.Day);
        }

        [Test]
        public void GetAgeFromDOB()
        {
            kata = new AgeFromDob(new StaticClock(new DateTime(2008, 09, 3)));
            Assert.AreEqual(24, kata.GetAgeFromDOB(new DateTime(1984, 04, 23)));

            kata = new AgeFromDob(new StaticClock(new DateTime(2015, 09, 3)));
            Assert.AreEqual(31, kata.GetAgeFromDOB(new DateTime(1984, 04, 23)));

            kata = new AgeFromDob(new StaticClock(new DateTime(2020, 11, 9)));
            Assert.AreEqual(36, kata.GetAgeFromDOB(new DateTime(1984, 04, 23)));

            kata = new AgeFromDob(new StaticClock(new DateTime(2025, 08, 1)));
            Assert.AreEqual(38, kata.GetAgeFromDOB(new DateTime(1987, 01, 15)));

            kata = new AgeFromDob(new StaticClock(new DateTime(2003, 01, 1)));
            Assert.AreEqual(1, kata.GetAgeFromDOB(new DateTime(2002, 01, 01)));
        }
    }
}