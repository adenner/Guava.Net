using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guava.Net.Collection
{
    public static class BitArrayHelper
    {
        /// <summary>
        /// Counts set bits
        /// </summary>
        public static int CountSetBits(this BitArray bits)
        {
            int count = 0;
            foreach (bool bit in bits)
                count++;
            return count;
        }
    }
}
