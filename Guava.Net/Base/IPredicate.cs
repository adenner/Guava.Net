
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

namespace Guava.Base
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
