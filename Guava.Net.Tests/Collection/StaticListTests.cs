using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
/*
 * Copyright (C) 2015 Andrew Denner
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


namespace Guava.Collection.Tests
{
    [TestClass()]
    public class StaticListTests
    {
        private StaticList<int> MakeSUT()
        {
            List<int> backing = new List<int>() { { 1 }, { 2 }, { 3 } };
            return new StaticList<int>(backing);
        }

        [TestMethod()]
        public void StaticListTest()
        {
            var sut=MakeSUT();
            Assert.IsNotNull(sut);
        }

        [TestMethod()]
        [ExpectedException(typeof(NotImplementedException))]
        public void AddTest()
        {
            var sut = MakeSUT();
            sut.Add(3);
        }

        [TestMethod()]
        [ExpectedException(typeof(NotImplementedException))]
        public void ClearTest()
        {
            MakeSUT().Clear();
        }

        [TestMethod()]
        public void ContainsTest()
        {
            Assert.IsTrue(MakeSUT().Contains(1));
        }

        [TestMethod()]
        [ExpectedException(typeof(NotImplementedException))]
        public void CopyToTest()
        {
            MakeSUT().CopyTo(new int[2], 1);
        }

        [TestMethod()]
        public void GetEnumeratorTest()
        {
            var enu = MakeSUT().GetEnumerator();
            Assert.IsNotNull(enu);
        }

        [TestMethod()]
        public void IndexOfTest()
        {
            Assert.IsTrue(MakeSUT().IndexOf(1)==0);
        }

        [TestMethod()]
        [ExpectedException(typeof(NotImplementedException))]
        public void InsertTest()
        {
            MakeSUT().Insert(3, 3);
        }

        [TestMethod()]
        [ExpectedException(typeof(NotImplementedException))]
        public void RemoveTest()
        {
            MakeSUT().Remove(3);
        }

        [TestMethod()]
        [ExpectedException(typeof(NotImplementedException))]
        public void RemoveAtTest()
        {
            MakeSUT().RemoveAt(1);
        }
    }
}