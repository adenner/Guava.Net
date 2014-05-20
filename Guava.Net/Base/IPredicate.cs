using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guava.Net.Base
{
    /// <summary>
    /// Determines a true or false value for a given input.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPredicate<T>
    {
        /// <summary>
        /// Returns the result of applying this predicate to T.
        /// 1) Should not have observable side-effects.
        /// 2) Computation should be consistent to Equals.  
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool Apply(T input);
        
        /// <summary>
        /// Indicates whether another object is equal to this predicate.
        /// </summary>
        bool Equals(T input);
    }
}
