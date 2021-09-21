using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace S6_ListViewExample
{
    public class PartenersGrouping<K, T> : ObservableCollection<T>
    {
        public K Key { get; private set; }

        public PartenersGrouping(K key, IEnumerable<T> items)
        {
            Key = key;
            foreach (var item in items)
            {
                this.Items.Add(item);
            }
        }
    }
}
