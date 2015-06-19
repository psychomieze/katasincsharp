using NUnit.Framework;
using Katas.CodeWars;
namespace KatasTests.CodeWars
{
    public class NoobifierTests
    {
  
        [TestCase("too to today", "2 2 2day")]
        [TestCase("for fore forward", "4 4 4ward")]
        [TestCase("be are you please people really have know", "b R u PLZ ppl RLY haz NO")]
        [TestCase("ss", "zz")]
        [TestCase("with a w", "LOL WITH a W")]
        [TestCase("0123456789112345678901234567890123456", "OMG 0123456789112345678901234567890123456", TestName = "OMG at more than 32 chars")]
        [TestCase("w0123456789112345678901234567890123456", "LOL OMG w0123456789112345678901234567890123456", TestName = "OMG at more than 32 chars with LOL")]
        [TestCase("W0123456789112345678901234567890123456", "LOL OMG W0123456789112345678901234567890123456", TestName = "OMG at more than 32 chars with LOL")]
        [TestCase("foo", "f00")]
        [TestCase("fOO", "f00")]
        [TestCase("bar bar bar bar", "bar BAR bar BAR")]
        [TestCase("help I need somebody", "HELP I NEED ZOMEBODY")]
        [TestCase("Help I need somebody", "HELP I NEED ZOMEBODY")]
        [TestCase(",'.", "")]
        [TestCase("me me me?", "me ME me???")]
        [TestCase("me me me? me", "me ME me???? ME")]
        [TestCase("me me me me!", "me ME me ME!1!1")]
        [TestCase("me me me me! me", "me ME me ME!1!1! me")]
        [TestCase("After conversions this should be!", "After CONVERZIONZ thiz ZHOULD b!1!1!")]
        [TestCase(
            "Before you know it... wait, what does this have to do with UNO!?",
            "OMG B4 u NO it WAIT what DOEZ thiz HAZ 2 DO with UNO!1!1!1!1!1!1!1??????????????"
            )]
        public void CheckNoobifier(string input, string expected)
        {
             Assert.AreEqual(expected, Noobifier.N00bify(input));
        }



        [Test]
        public static void HowRU()
        {
            Assert.AreEqual(
                "HI HOW R U 2DAY?????", 
                Noobifier.N00bify("Hi, how are you today?")
            );
        }

        [Test]
        public static void LongSentence()
        {
            Assert.AreEqual("OMG I think IT would B nice IF we COULD all GET along",
               Noobifier.N00bify("I think it would be nice if we could all get along."));
        }

        [Test]
        public static void CommasMatter()
        {
            Assert.AreEqual("Letz EAT Grandma!1!",
            Noobifier.N00bify("Let's eat, Grandma!"));
        }
    }
}