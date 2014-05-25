using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    /// Static methods pertaining to ASCII characters (those in range of values 0x00 to 0x7F, and to strings
    /// containing such characters.
    /// </summary>
    public static class Ascii
    {
        #region ASCII CONTROL CHARACTERS 

        /// <summary>
        /// Null ('\0'): The all-zeros character which may serve to accomplish time fill and media fill.
        /// Normally used as a C string terminator.  Although RFC 20 names this as "Null", note that it
        /// is distinct from the C/C++ "NULL" pointer.
        /// </summary>
        public static readonly byte NUL = 0;

        #endregion

        /// <summary>
        /// Returns a copy of the input string in which all Upper Case ASCII characters
        /// have been converted to lowercase.  All other characters are copied without modification.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String ToLowerCase(String str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                // If we find an upper case character will convert all the characters that follow.
                if (IsUpperCase(str[i]))
                {
                    char[] chars = str.ToCharArray(); // Creates copy to modify 
                    for (; i < str.Length; i++)
                    {
                        char c = chars[i];
                        if (IsUpperCase(c))
                            chars[i] = (char)(c ^ 0x20); // XOR 6th bit to convert to all lower case Ex: A = 01000001 => a = 01100001
                    }
                    return chars.ToString();
                }
            }
            return str;
        }

        public static char ToLowerCase(char c)
        {
            // XOR 6th bit to convert to all lower case Ex: A = 01000001 => a = 01100001
            return IsUpperCase(c) ? (char)(c ^ 0x20) : c;
        }

        /// <summary>
        /// Returns true if c is one of the 26 lowercase ASCII alpha characters between a and z inclusive.  
        /// All other characters return false;
        /// </summary>
        private static bool IsLowerCase(char c)
        {
            return (c >= 'a') && (c <= 'z');
        }

        /// <summary>
        /// Returns true if c is one of the 26 uppercase ASCII alpha characters between A and Z inclusive.
        /// All other characters return false;
        /// </summary>
        private static bool IsUpperCase(char c)
        {
            return (c >= 'A') && (c <= 'Z');
        }
    }
}
