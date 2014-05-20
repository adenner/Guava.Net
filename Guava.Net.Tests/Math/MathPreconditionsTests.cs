using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guava.Net.Math;

namespace Guava.Net.Tests
{
    [TestClass]
    public class MathPreconditionsTests 
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckPositive_WhenZero_ExpectZero()
        {
            int num = 0;
            num.CheckPositive("int");
        }
    }
}
