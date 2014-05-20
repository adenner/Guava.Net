using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Guava.Net.Math
{
    /// <summary>
    /// A collection of preconditions for math functions.
    /// </summary>
    public static class MathPreconditions
    {
        public static int CheckPositive(this int x, string role)
        {
            if (x <= 0) { throw new ArgumentOutOfRangeException(role + " (" + x + ") must be > 0"); }
            return x;
        }

        public static long CheckPositive(this long x, string role)
        {
            if (x <= 0) { throw new ArgumentOutOfRangeException(role + " (" + x + ") must be > 0"); }
            return x;
        }

        public static BigInteger CheckPositive(this BigInteger x, string role)
        {
            if (x <= 0) { throw new ArgumentOutOfRangeException(role + " (" + x + ") must be > 0"); }
            return x;
        }

        public static int CheckNonNegative(this int x, string role)
        {
            if (x < 0) { throw new ArgumentOutOfRangeException(role + " (" + x + ") must be > 0"); }
            return x;
        }

        public static long CheckNonNegative(this long x, string role)
        {
            if (x < 0) { throw new ArgumentOutOfRangeException(role + " (" + x + ") must be > 0"); }
            return x;
        }

        public static BigInteger CheckNonNegative(this BigInteger x, string role)
        {
            if (x.Sign < 0) { throw new ArgumentOutOfRangeException(role + " (" + x + ") must be > 0"); }
            return x;
        }
    }
}
