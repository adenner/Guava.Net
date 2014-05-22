using Guava.Base;
using Guava.Collection;
using System;
using System.Collections;
using System.Runtime.Serialization;

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

namespace Guava.Hash
{
    public sealed class BloomFilter<T> : IPredicate<T>, ISerializable 
    {
        public interface Stratagy
        {
            /// <summary>
            /// Sets bits of a given bit array, but hashing object.
            /// </summary>
            /// <returns>Whether any bits changed as a result of operation.</returns>
            bool Put(T obj, Funnel<T> funnel, int numHashFunctions, BitArray bits);

            /// <summary>
            /// Queries bits of a the given array, by hashing user object.
            /// </summary>
            /// <returns>True if and only if the selected bits are set.</returns>
            bool MightContain(T obj, Funnel<T> funnel, int numOfHasFunctions, BitArray bits);

            /// <summary>
            /// Identifier used to encode this strategy, when marshalled as part of a BloomFilter. 
            /// Only values in the [-128, 127] range are valid for the compact serial form.
            /// Non-negative values are reserved for enums defined in BloomFilterStrategies;
            /// negative values are reserved for any custom, stateful strategy we may define
            /// (e.g. any kind of strategy that would depend on user input).
            /// </summary>
            int Original();
        }

        #region PRIVATE FIELDS

        /// <summary>
        /// The bit set of the filter.  Not necessarily at power of 2!
        /// </summary>
        private readonly BitArray bits;

        /// <summary>
        /// The number of hashes per element.
        /// </summary>
        private readonly int numOfHashFunctions;

        /// <summary>
        /// The funnel to translate Ts to bytes
        /// </summary>
        private readonly Funnel<T> funnel;

        /// <summary>
        /// The strategy we employ to map an element T to bit indexes.
        /// </summary>
        private readonly Stratagy strategy;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Creates a new Bloom Filter.
        /// </summary>
        public BloomFilter(BitArray bits, int numOfHashFunctions, Funnel<T> funnel, Stratagy strategy)
        {
            this.bits = bits;
            this.numOfHashFunctions = numOfHashFunctions;
            this.funnel = funnel;
            this.strategy = strategy;
        }

        /// <summary>
        /// Creates a new copy.  The new instance is equal to but shares no mutable state.
        /// </summary>
        /// <param name="that">Filter to copy</param>
        public BloomFilter(BloomFilter<T> that)
        {
            throw new NotImplementedException();
        }

        #endregion

        public bool MightContain(T obj)
        {
            return strategy.MightContain(obj, funnel, numOfHashFunctions, bits);
        }

        [Obsolete()]
        public bool Apply(T input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Puts an element into filter.  Ensure that subsequent invocations of MightContain with
        /// with the same element will always return true;
        /// </summary>
        /// <returns>True if element has already been put in filter.</returns>
        public bool Put(T obj)
        {
            return strategy.Put(obj, funnel, numOfHashFunctions, bits);
        }

        public double ExpectedFpp
        {
            get {return CalcExpectedFpp(bits.CountSetBits(), BitSize, numOfHashFunctions); }
        }

        public int BitSize
        {
            get { return bits.Count; }
        }

        /// <summary>
        /// Determines if a given bloom filter is compatible with this filter. To be compatible:
        /// 1) not have the same interface
        /// 2) have the same number of hash functions
        /// 3) have the same bit size
        /// 4) have equal funnels 
        /// </summary>
        public bool IsCompatible(BloomFilter<T> that)
        {
            Preconditions.CheckNotNull(that);

            return (this != that) &&
                this.numOfHashFunctions == that.numOfHashFunctions &&
                this.BitSize == that.BitSize &&
                this.strategy.Equals(that.strategy) &&
                this.funnel.Equals(that.funnel);
        }

        // TODO: ....

        /// <summary>
        /// Visible for testing
        /// </summary>
        internal static double CalcExpectedFpp(double countBits, double bitSize, int numOfHashFunctions)
        {
            // TODO: Check for zero bits.Count ???
            return System.Math.Pow(countBits / bitSize, numOfHashFunctions);
        }

        /// <summary>
        /// Visible for testing
        /// </summary>
        internal static double OptimalNumOfHashFunctions(long n, long m)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Visible for testing
        /// </summary>
        internal static double OptimalNumOfBits(long n, long m)
        {
            throw new NotImplementedException();
        }

        public bool Equals(T input)
        {
            throw new NotImplementedException();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
