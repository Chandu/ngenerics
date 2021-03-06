/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System;
using System.Collections.Generic;
using NGenerics.DataStructures.Queues;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Queues.MaxPriorityQueueHeapTests
{
    [TestFixture]
    public class CopyTo : MaxPriorityQueueTest
    {

        [Test]
        public void Simple()
        {
            var priorityQueue = GetTestPriorityQueue();
            var array = new string[priorityQueue.Count];

            priorityQueue.CopyTo(array, 0);

            var list = new List<string>(array);

            Assert.AreEqual(list.Count, priorityQueue.Count);

            Assert.IsTrue(list.Contains("a"));
            Assert.IsTrue(list.Contains("b"));
            Assert.IsTrue(list.Contains("c"));
            Assert.IsTrue(list.Contains("d"));
            Assert.IsTrue(list.Contains("e"));
            Assert.IsTrue(list.Contains("f"));

            Assert.IsTrue(list.Contains("u"));
            Assert.IsTrue(list.Contains("v"));
            Assert.IsTrue(list.Contains("w"));
            Assert.IsTrue(list.Contains("x"));
            Assert.IsTrue(list.Contains("y"));
            Assert.IsTrue(list.Contains("z"));
        }

        [Test]
        public void ExceptionNullArray()
        {
            var priorityQueue = new PriorityQueue<string, int>(PriorityQueueType.Maximum);
            Assert.Throws<ArgumentNullException>(() => priorityQueue.CopyTo(null, 0));
        }

        [Test]
        public void ExceptionInvalid1()
        {
            var priorityQueue = GetTestPriorityQueue();

            var array = new string[priorityQueue.Count - 1];
            Assert.Throws<ArgumentException>(() => priorityQueue.CopyTo(array, 0));
        }

        [Test]
        public void ExceptionInvalid2()
        {
            var priorityQueue = GetTestPriorityQueue();

            var array = new string[priorityQueue.Count];
            Assert.Throws<ArgumentException>(() => priorityQueue.CopyTo(array, 1));
        }
    }
}