/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/

using System;
using NGenerics.Comparers;
using NGenerics.Tests.Util;
using NUnit.Framework;

namespace NGenerics.Tests.Comparers.ComparisonComparerTests
{
    [TestFixture]
    public class Construction : ComparisonComparerTest
    {
        [Test]
        public void Simple()
        {
            var comparer = GetTestComparer();

            Assert.IsNotNull(comparer.Comparison);

            comparer.Comparison = ((x, y) => x.TestProperty.CompareTo(y.TestProperty));
        }

        [Test]
        public void ExceptionNullComparison()
        {
            Assert.Throws<ArgumentNullException>(() => new ComparisonComparer<SimpleClass>(null));
        }
    }
}