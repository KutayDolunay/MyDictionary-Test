using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary_Test
{
    public class MyDictionary<TKey, TValue>
    {
        public List<KeyValuePair<TKey, TValue>> Items { get; private set; }

        public MyDictionary()
        {
            Items = new List<KeyValuePair<TKey, TValue>>();
        }

        public void Add(TKey key, TValue value)
        {
            Items.Add(new KeyValuePair<TKey, TValue>(key, value));
        }
    }
}
