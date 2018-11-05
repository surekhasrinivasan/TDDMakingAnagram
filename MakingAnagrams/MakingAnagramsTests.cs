using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnagrams
{
    [TestFixture]
    class MakingAnagramsTests
    {
        [Test]
        public void IsOutputAnInteger()
        {
            Assert.AreEqual(typeof(int), MakeAnagram.charactersDeleted("abc", "bcd").GetType());
        }

        [Test]
        public void InputsSameReturnZero()
        {
            int result = MakeAnagram.charactersDeleted("abc", "abc");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CheckforTheOrderOfChars()
        {
            int result = MakeAnagram.charactersDeleted("abc", "cab");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void InputOneDifferentCharReturns2()
        {
            int result = MakeAnagram.charactersDeleted("abd", "abc");
            Assert.AreEqual(2, result);
        }
    }

    
}
