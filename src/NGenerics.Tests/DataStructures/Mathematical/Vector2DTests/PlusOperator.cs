/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System;
using NGenerics.DataStructures.Mathematical;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.Vector2DTests
{
    [TestFixture]
    public class PlusOperator
    {
        [Test]
        public void Double()
        {
            var vector2D = new Vector2D(4, 7);
            var vector = vector2D + 2;
            Assert.AreEqual(6, vector.X);
            Assert.AreEqual(9, vector.Y);
            Assert.AreEqual(4, vector2D.X);
            Assert.AreEqual(7, vector2D.Y);
            Assert.AreNotSame(vector2D, vector);
        }


        [Test]
        public void Vector()
        {
            var vector1 = new Vector2D(4, 7);
            var vector2 = new Vector2D(3, 4);
            var vector = vector1 + vector2;
            Assert.AreEqual(7, vector.X);
            Assert.AreEqual(11, vector.Y);
            Assert.AreEqual(4, vector1.X);
            Assert.AreEqual(7, vector1.Y);
            Assert.AreEqual(3, vector2.X);
            Assert.AreEqual(4, vector2.Y);
            Assert.AreNotSame(vector1, vector);
            Assert.AreNotSame(vector2, vector);
        }


        [Test]
        public void ExceptionDifferentDimensions()
        {
            var vector2D = new Vector2D();
            var vector3D = new Vector3D();
            IVector<double> vector;
            Assert.Throws<ArgumentException>(() => vector = vector2D + vector3D);
        }


        [Test]
        public void ExceptionLeftNull()
        {
            var vector2D1 = new Vector2D();
            Vector2D vector;
            Assert.Throws<ArgumentNullException>(() => vector = null + vector2D1);
        }


        [Test]
        public void ExceptionRightNull()
        {
            var vector2D1 = new Vector2D();
            Vector2D vector;
            Assert.Throws<ArgumentNullException>(() => vector = vector2D1 + null);
        }
    }
}