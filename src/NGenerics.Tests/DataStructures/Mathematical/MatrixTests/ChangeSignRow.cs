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

namespace NGenerics.Tests.DataStructures.Mathematical.MatrixTests
{
    [TestFixture]
    public class ChangeSignRow
    {

        [Test]
        public void Simple()
        {
            var matrix = new Matrix(3, 3);

            // [ 1,  4,  7 ]
            // [ 2,  5,  8 ]
            // [ 3,  6,  9 ]


            matrix[0, 0] = 1;
            matrix[0, 1] = 4;
            matrix[0, 2] = 7;

            matrix[1, 0] = 2;
            matrix[1, 1] = 5;
            matrix[1, 2] = 8;

            matrix[2, 0] = 3;
            matrix[2, 1] = 6;
            matrix[2, 2] = 9;

            matrix.ChangeSignRow(1);

            Assert.AreEqual(matrix[1, 0], -2);
            Assert.AreEqual(matrix[1, 1], -5);
            Assert.AreEqual(matrix[1, 2], -8);
        }

        [Test]
        public void ExceptionRowIndexLessThan0()
        {
            var matrix = new Matrix(3, 3);
            Assert.Throws<ArgumentOutOfRangeException>(() => matrix.ChangeSignRow(-1));
        }

        [Test]
        public void ExceptionRowIndexGreaterThanRowCount()
        {
            var matrix = new Matrix(3, 3);
            Assert.Throws<ArgumentOutOfRangeException>(() => matrix.ChangeSignRow(3));
        }
    }
}