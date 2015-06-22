using Katas;
using NUnit.Framework;

namespace KatasTests
{
    public class NoobifierTests
    {
        [TestCase("to", "2")]
        [TestCase("too", "2")]
        [TestCase("today", "2day")]
        [TestCase("To", "2")]
        [TestCase("for", "4")]
        [TestCase("fore", "4")]
        [TestCase("oo", "00")]
        [TestCase("be", "b")]
        [TestCase("are", "r")]
        [TestCase("you", "u")]
        [TestCase("please", "plz")]
        [TestCase("people", "ppl")]
        [TestCase("really", "rly")]
        [TestCase("have", "haz")]
        [TestCase("know", "no")]
        [TestCase("sSs", "zZz")]
        public void ReplacementsTests(string input, string expected)
        {
            string noobifiedText = Noobifier.Noobify(input);
            Assert.AreEqual(expected, noobifiedText);
        }

        [Test]
        public void LolIsAddedIfStringStartsWithW() 
        {
            Assert.AreEqual("LOL WTF", Noobifier.Noobify("Wtf"));
            Assert.AreEqual("LOL WTF", Noobifier.Noobify("wtf"));
        }

        [Test]
        public void OmgIsAddedIfStringIsLongerOrEqualTo32Chars() 
        {
            Assert.AreEqual(
                "OMG ABCDEFGH abcdefgh ABCDEFGH abcdef",
                Noobifier.Noobify("abcdefgh abcdefgh abcdefgh abcdef")
                );
        }

        [Test]
        public void OmgIsAddedAfterLolIfStringIsLongerOrEqualTo32CharsAndStartsWithW()
        {
            Assert.AreEqual(
                "LOL OMG wbcdefgh ABCDEFGH abcdefgh ABCDEF",
                Noobifier.Noobify("wbcdefgh abcdefgh abcdefgh abcdef")
                );
        }

        [Test]
        public void EvenlyNumberedWordsShouldBeReturnedUpperCased() 
        {
            Assert.AreEqual(
                "Cake IZ very DELICIOUZ",
                Noobifier.Noobify("Cake is very delicious")
                );
        }
    }
}