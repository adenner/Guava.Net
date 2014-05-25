using Guava.Base;
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

namespace Guava.Tests.Base
{
    [TestClass]
    public class DefaultsTests
    {
        private class FakeClass {}

        [TestMethod]
        public void DefaultValue_WhenGetDefault_ExpectMatchDefaultValues()
        {
            Assert.AreEqual(false, Defaults.DefaultValue<bool>()); 
            Assert.AreEqual('\0', Defaults.DefaultValue<char>()); 
            Assert.AreEqual(0, Defaults.DefaultValue<short>()); 
            Assert.AreEqual(0, Defaults.DefaultValue<int>()); 
            Assert.AreEqual(0, Defaults.DefaultValue<long>()); 
            Assert.AreEqual(0.0F, Defaults.DefaultValue<float>()); 
            Assert.AreEqual(0.0D, Defaults.DefaultValue<double>());

            // TODO: Determine if .NET has the equivalent of Java's class.void.
            //Assert.IsNull(Defaults.DefaultValue(typeof(void)));

            Assert.IsNull(Defaults.DefaultValue<string>());
        }
    }
}
