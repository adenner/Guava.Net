using Guava.Net.Base;
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

namespace Guava.Net.Tests.Base
{
    [TestClass]
    public class PreconditionsTests
    {
        [TestMethod]
        public void CheckArgument_WhenTrueNoArgs_ExpectOK()
        {
            Preconditions.CheckArgument(true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckArgument_WhenFalse_ExpectException()
        {
            Preconditions.CheckArgument(false);
        }

        [TestMethod]
        public void CheckArgument_WhenTrue_ExpectOK()
        {
            Preconditions.CheckArgument(true, IGNORE_ME);
        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        public void CheckArgument_WhenTrue_ExpectSimpleExceptionMessage()
        {
            try
            {
                Preconditions.CheckArgument(false, new Message());
            }
            catch (Exception e)
            {
                verifySimpleMessage(e);
            }
        }

        [TestMethod]
        public void CheckArgument_WhenNullMessage_ExpectException()
        {
            
        }

        private class IgnoreMe : Object
        {
            public override string ToString()
            {
                throw new AssertFailedException("Expected object to be ignored.");
            }
        }
        private static Object IGNORE_ME = new IgnoreMe();

        private class Message
        {
            bool invoked;
            public override string ToString()
            {
                Assert.IsFalse(invoked);
                invoked = true;
                return "A message";
            }
        }

        private const String FORMAT = "I ate %s pies.";

        private static void verifySimpleMessage(Exception e)
        {
            Assert.Equals("A message", e.Message);
        }
        
        private static void VerifyComplextMessage(Exception e)
        {
            //Assert.Equals("I ate 5 pies.", e.getMessage());
        }
    }
}
