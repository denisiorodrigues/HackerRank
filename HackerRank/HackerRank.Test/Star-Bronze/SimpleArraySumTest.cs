using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using HackerRank.Star_Bronze;

namespace HackerRank.Test.Star_Bronze
{
    public class SimpleArraySumTest
    {
        [Theory]
        [InlineData(6, new int [] { 1, 2, 3 })]
        [InlineData(31, new int [] { 1, 2, 3, 4, 10, 11 })]
        public void Calculator(int result, int [] arrayValue)
        {
            Assert.Equal(result, SimpleArraySum.Sum(arrayValue));
        }
    }
}
