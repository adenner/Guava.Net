
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

namespace Guava.Math
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
