using System;
using System.Numerics;

/*
 * Copyright (C) 2014 David Forshner
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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
