using System;
using System.Collections.Generic;

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
    /// Provides default values for all .NET types.
    /// </summary>
    public static class Defaults
    {
        private static readonly IDictionary<Type, Object> DEFAULTS;

        static Defaults()
        {
            DEFAULTS = new Dictionary<Type, Object>()
            {
                { typeof(bool), false },
                { typeof(char), '\0'},
                { typeof(byte), (byte) 0},
                { typeof(short), (short) 0},
                { typeof(int), 0 },
                { typeof(long), 0L },
                { typeof(float), 0F },
                { typeof(double), 0D },
            };
        }

        /// <summary>
        /// Returns the default value for type.
        /// TODO: This method doesn't handle the class.void (System.Void?) case.
        /// </summary>
        public static T DefaultValue<T>()
        {
            var type = typeof(T);

            Object obj;
            if (DEFAULTS.TryGetValue(type, out obj))
                return (T) obj;
            else
                return default(T);
        }
    }
}