using Katas.CodeWars;
using NUnit.Framework;

namespace KatasTests.CodeWars
{
    public class PatternCompletionTests
    {
        PatternCompletion k = new PatternCompletion();
        [Test]
        public void SimpleNumbers()
        {
            Assert.AreEqual("1", k.Pattern(1));
            Assert.AreEqual("1\n22", k.Pattern(2));
            Assert.AreEqual("1\n22\n333\n4444\n55555", k.Pattern(5));
        }
    }
}