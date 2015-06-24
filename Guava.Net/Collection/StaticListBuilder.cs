using System.Collections.Generic;

namespace Guava.Collection
{
    class StaticListBuilder<T>
    {
        private List<T> m_list;
        public StaticListBuilder()
        {
            m_list=new List<T>();
        }
        public StaticListBuilder(int count)
        {
            m_list = new List<T>(count);
        }
        public void Add(T item)
        {
            m_list.Add(item);
        }
        public void Add(IEnumerable<T> items)
        {
            m_list.AddRange(items);
        }
        public StaticList<T> Build()
        {
            return new StaticList<T>(m_list);
        }

    }
}
