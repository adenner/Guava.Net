using Guava.Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;

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

namespace Guava.Tests
{
    [TestClass]
    public class MathPreconditionsTests
    {
        #region CheckPositive

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckPositive_WhenZero_ExpectException()
        {
            int num = 0;
            num.CheckPositive("int");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckPositive_WhenZeroInt_ExpectException()
        {
            MathPreconditions.CheckPositive(0, "int");
        }

        [TestMethod]
        public void CheckPositive_WhenMaxInt_ExpectOK()
        {
            MathPreconditions.CheckPositive(int.MaxValue, "int");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckPositive_WhenMinInt_ExpectException()
        {
            MathPreconditions.CheckPositive(int.MinValue, "int");
        }
 
        [TestMethod]
        public void CheckPositive_WhenOneInt_ExpectOK()
        {
            MathPreconditions.CheckPositive(1, "int");
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckPositive_WhenNegativeInt_ExpectException()
        {
            MathPreconditions.CheckPositive(-1, "int");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckPositive_WhenZeroLong_ExpectException()
        {
            MathPreconditions.CheckPositive(0, "long");
        }

        [TestMethod]
        public void CheckPositive_WhenMaxLong_ExpectOK()
        {
            MathPreconditions.CheckPositive(long.MaxValue, "long");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckPositive_WhenMinLong_ExpectException()
        {
            MathPreconditions.CheckPositive(long.MinValue, "long");
        }

        [TestMethod]
        public void CheckPositive_WhenPositiveLong_ExpectOK()
        {
            MathPreconditions.CheckPositive(+1L, "long");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckPositive_WhenNegativeLong_ExpectException()
        {
            MathPreconditions.CheckPositive(-1L, "long");
        }
       
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckPositive_WhenZeroBigInteger_ExpectException()
        {
            MathPreconditions.CheckPositive(new BigInteger(0), "BigInteger");
        }

        [TestMethod]
        public void CheckPositive_WhenPositiveBigInteger_ExpectOK()
        {
            MathPreconditions.CheckPositive(new BigInteger(1L), "BigInteger");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckPositive_WhenNegativeInteger_ExpectException()
        {
            MathPreconditions.CheckPositive(new BigInteger(-1), "BigInteger");
        }

        #endregion

        #region CheckNonNegative

        [TestMethod]
        public void CheckNonNegtive_WhenZero_ExpectOK()
        {
            MathPreconditions.CheckNonNegative(0, "int");
        }
              
        [TestMethod]
        public void CheckNonNegative_WhenMaxInt_ExpectOK()
        {
            MathPreconditions.CheckNonNegative(int.MaxValue, "int");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckNonNegative_WhenMinInt_ExpectException()
        {
            // In Java the MIN_VALUE is a constant holding the smallest positive nonzero value of type double.
            // In C# the MinValue is the largest possible negative number.
            MathPreconditions.CheckNonNegative(int.MinValue, "int");
        }
 
        [TestMethod]
        public void CheckNonNegative_WhenOneInt_ExpectOK()
        {
            MathPreconditions.CheckNonNegative(1, "int");
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckNonNegative_WhenNegativeInt_ExpectException()
        {
            MathPreconditions.CheckNonNegative(-1, "int");
        }

        [TestMethod]
        public void CheckNonNegative_WhenZeroFloat_ExpectException()
        {
            MathPreconditions.CheckNonNegative(0F, "float");
        }

        [TestMethod]
        public void CheckNonNegative_WhenMaxFloat_ExpectOK()
        {
            MathPreconditions.CheckNonNegative(float.MaxValue, "float");
        }

        [TestMethod]
        public void CheckNonNegative_WhenEpsilonFloat_ExpectOK()
        {
            MathPreconditions.CheckNonNegative(float.Epsilon, "float");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckNonNegative_WhenMinFloat_ExpectException()
        {
            // In Java the MIN_VALUE is a constant holding the smallest positive nonzero value of type double.
            // In C# the MinValue is the largest possible negative number.
            MathPreconditions.CheckNonNegative(float.MinValue, "float");
        }

        [TestMethod]
        public void CheckNonNegative_WhenPositiveFloat_ExpectOK()
        {
            MathPreconditions.CheckNonNegative(+1F, "float");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckNonNegative_WhenNegativeFloat_ExpectException()
        {
            MathPreconditions.CheckNonNegative(-1F, "float");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckNonNegative_WhenNanFloat_ExpectException()
        {
            MathPreconditions.CheckNonNegative(float.NaN, "float");
        }

        [TestMethod]
        public void CheckNonNegative_WhenZeroDouble_ExpectException()
        {
            MathPreconditions.CheckNonNegative(0D, "double");
        }

        [TestMethod]
        public void CheckNonNegative_WhenMaxDouble_ExpectOK()
        {
            MathPreconditions.CheckNonNegative(double.MaxValue, "double");
        }

        [TestMethod]
        public void CheckNonNegative_WhenEpsilonDouble_ExpectOK()
        {
            MathPreconditions.CheckNonNegative(double.Epsilon, "double");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckNonNegative_WhenMinDouble_ExpectException()
        {
            // In Java the MIN_VALUE is a constant holding the smallest positive nonzero value of type double.
            // In C# the MinValue is the largest possible negative number.
            MathPreconditions.CheckNonNegative(double.MinValue, "double");
        }

        [TestMethod]
        public void CheckNonNegative_WhenPositiveDouble_ExpectOK()
        {
            MathPreconditions.CheckNonNegative(+1D, "double");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckNonNegative_WhenNegativeDouble_ExpectException()
        {
            MathPreconditions.CheckNonNegative(-1D, "double");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckNonNegative_WhenNanDouble_ExpectException()
        {
            MathPreconditions.CheckNonNegative(double.NaN, "double");
        }

        #endregion

        [TestMethod]
        public void CheckRoundingUnnescessary_WhenTrue_ExpectOK()
        {
            MathPreconditions.CheckRoundingUnnescessary(true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void CheckRoundingUnnescessary_WhenFalse_ExpectException()
        {
            MathPreconditions.CheckRoundingUnnescessary(false);
        }

        [TestMethod]
        public void CheckInRange_WhenTrue_ExpectOK()
        {
            MathPreconditions.CheckInRange(true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void CheckInRange_WhenFalse_ExpectException()
        {
            MathPreconditions.CheckInRange(false);
        }

        [TestMethod]
        public void CheckNoOverflow_WhenTrue_ExpectOK()
        {
            MathPreconditions.CheckNoOverflow(true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void CheckNoOverflow_WhenFalse_ExpectException()
        {
            MathPreconditions.CheckNoOverflow(false);
        }
    }
}
