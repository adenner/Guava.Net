using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guava.Net.Math
{
    /// <summary>
    /// Utilities for double primitives.
    /// </summary>
    public static class DoubleUtils 
    {
        /// <summary>
        /// Returns its argument if it is non-negative, zero if it is negative.
        /// </summary>
        /// <param name="value">value to test</param>
        /// <returns>double</returns>
        static double EnsureNonNegative(this double value)
        {
            // checkArgument(!isNan(value));
            return (value > 0.0) ? value : 0.0;
        }
    }
}
