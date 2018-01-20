/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.MatrixTests
{
    [TestFixture]
    public class GetColumn
    {

        [Test]
        public void Simple()
        {
            var matrix = MatrixTest.GetTestMatrix();

            var columnCount = matrix.Columns;
            var rowCount = matrix.Rows;

            var column = matrix.GetColumn(0);

            Assert.AreEqual(matrix.Columns, columnCount);
            Assert.AreEqual(matrix.Rows, rowCount);

            Assert.AreEqual(column.Length, matrix.Rows);

            for (var i = 0; i < column.Length; i++)
            {
                Assert.AreEqual(column[i], i);
            }

            column = matrix.GetColumn(1);

            Assert.AreEqual(column.Length, matrix.Rows);

            for (var i = 0; i < column.Length; i++)
            {
                Assert.AreEqual(column[i], i + 1);
            }
        }

        [Test]
        public void ExceptionInvalidGetColumn1()
        {
            var matrix = MatrixTest.GetTestMatrix();
            Assert.Throws<ArgumentOutOfRangeException>(() => matrix.GetColumn(-1));
        }

        [Test]
        public void ExceptionInvalidGetColumn2()
        {
            var matrix = MatrixTest.GetTestMatrix();
            Assert.Throws<ArgumentOutOfRangeException>(() => matrix.GetColumn(matrix.Columns));
        }

        [Test]
        public void ExceptionInvalidGetColumn3()
        {
            var matrix = MatrixTest.GetTestMatrix();
            Assert.Throws<ArgumentOutOfRangeException>(() => matrix.GetColumn(matrix.Columns + 1));
        }
    }
}