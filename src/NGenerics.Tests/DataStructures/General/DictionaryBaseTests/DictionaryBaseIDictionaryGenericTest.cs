/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.General.DictionaryBaseTests
{
    [TestFixture]
    public class DictionaryBaseIDictionaryGenericTest
    {


        [Test]
        public void AddTest()
        {
            Assert.Throws<Exception>(() =>  
            new MockExceptionDictionary
                {
                    {2, 2}
                }, "AddItem");
        }


        [Test]
        public void ClearTest()
        {
            var target = new MockExceptionDictionary();
            Assert.Throws<ArgumentNullException>(() => target.Clear(), "ClearItems");
        }


        [Test]
        public void KeysTest()
        {
            var target = new MockStringDictionary { { "a", "b" }, { "f", "b" }, { "g", "b" } };
            var keys = target.Keys;

            Assert.AreEqual(3, keys.Count);
            Assert.IsTrue(keys.Contains("a"));
            Assert.IsTrue(keys.Contains("f"));
            Assert.IsTrue(keys.Contains("g"));
        }


        [Test]
        public void IndexerTest()
        {
            var target = new MockExceptionDictionary();
            Assert.Throws<Exception>(() =>  target[2] = 2, "SetItem");
        }


        [Test]
        public void RemoveTest()
        {
            var target = new MockExceptionDictionary();
            Assert.Throws<Exception>(() => target.Remove(2), "RemoveItem");
        }


        [Test]
        public void ValuesTest()
        {
            var target = new MockStringDictionary { { "a", "b" }, { "f", "s" }, { "g", "z" } };
            var values = target.Values;

            Assert.AreEqual(3, values.Count);
            Assert.IsTrue(values.Contains("b"));
            Assert.IsTrue(values.Contains("s"));
            Assert.IsTrue(values.Contains("z"));
        }
    }
}