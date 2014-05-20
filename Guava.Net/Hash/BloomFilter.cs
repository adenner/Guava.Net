using Guava.Net.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Guava.Net.Hash
{
    public sealed class BloomFilter<T> : IPredicate<T>, ISerializable 
    {
        public bool Apply(T input)
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
