using Guava.Net.Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

namespace Guava.Net.Tests
{
    [TestClass]
    public class MathPreconditionsTests 
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckPositive_WhenZero_ExpectZero()
        {
            int num = 0;
            num.CheckPositive("int");
        }
    }
}
