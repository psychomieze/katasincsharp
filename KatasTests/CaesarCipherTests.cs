using System.Collections.Generic;
using Katas;
using NUnit.Framework;

namespace KatasTests
{
    public class CaesarCipherTests
    {

        [Test]
        public void Cipher() 
        {
            string u = "I should have known that you would have a perfect answer for me!!!";
            List<string> resultList = new List<string>
            {
                "J vltasl rlhr ", "zdfog odxr ypw", " atasl rlhr p ", "gwkzzyq zntyhv", " lvz wp!!!"
            };
            Assert.AreEqual(resultList, CaesarCipher.movingShift(u, 1));
        }

        [Test]
        public void Test1()
        {
            string u = "I should have known that you would have a perfect answer for me!!!";
            List<string> movingShift = CaesarCipher.movingShift(u, 1);
            string demovingShift = CaesarCipher.demovingShift(movingShift, 1);
            Assert.AreEqual(u, demovingShift);
        }
    }
}