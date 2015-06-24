using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

namespace Guava.Collection
{
/// <summary>
///  An IList that is static. If you try to do writeable stuff to it, it will throw not implemented exceptions.
/// </summary>
/// <typeparam name="T"></typeparam>
    public class StaticList<T> : IList<T>
    {
        private IList<T> m_backing;
        private StaticList()
        {
            m_backing = new List<T>();
        }
        public StaticList(IList<T> items)
        {
            m_backing = items;
        }
        public StaticList(IEnumerable<T> items)
        {
            m_backing = new List<T>(items);
        }

        public T this[int index]
        {
            get
            {
                return m_backing[index];
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                return m_backing.Count();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return true;
            }
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            return m_backing.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return m_backing.GetEnumerator();
        }
        public int IndexOf(T item)
        {
            return m_backing.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return m_backing.GetEnumerator();
        }
    }
}
