/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System;
using NGenerics.DataStructures.General;
using NGenerics.DataStructures.Mathematical;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.VectorNTests
{
    [TestFixture]
    public class MultiplyOperator
    {
        [Test]
        public void Double()
        {
            var vector1 = new VectorN(2);
            vector1.SetValues(4, 7);

            var vector = vector1 * 2;

            Assert.AreEqual(8, vector[0]);
            Assert.AreEqual(14, vector[1]);

            Assert.AreEqual(4, vector1[0]);
            Assert.AreEqual(7, vector1[1]);

            Assert.AreNotSame(vector1, vector);
        }


        [Test]
        public void Vector()
        {
            var vector1 = new VectorN(2);
            vector1.SetValues(4, 7);
            var vector2 = new VectorN(2);
            vector2.SetValues(3, 4);

            var matrix = vector1 * vector2;

            Assert.AreEqual(2, matrix.Columns);
            Assert.AreEqual(2, matrix.Rows);

            Assert.AreEqual(12, matrix[0, 0]);
            Assert.AreEqual(16, matrix[0, 1]);
            Assert.AreEqual(21, matrix[1, 0]);
            Assert.AreEqual(28, matrix[1, 1]);

            Assert.AreEqual(4, vector1[0]);
            Assert.AreEqual(7, vector1[1]);
            Assert.AreEqual(3, vector2[0]);
            Assert.AreEqual(4, vector2[1]);
        }


        [Test]
        public void ExceptionDifferentDimensions()
        {
            var vector1 = new VectorN(2);
            var vector2 = new VectorN(4);

            IMatrix<double> matrix;
            Assert.Throws<ArgumentException>(() => matrix = vector1 * vector2);
        }


        [Test]
        public void ExceptionLeftNull()
        {
            var vector1 = new VectorN(2);
            IMatrix<double> matrix;
            Assert.Throws<ArgumentNullException>(() => matrix = null * vector1);
        }


        [Test]
        public void ExceptionRightNull()
        {
            var vector1 = new VectorN(2);
            IMatrix<double> matrix;
            Assert.Throws<ArgumentNullException>(() => matrix = vector1 * null);
        }
    }
}