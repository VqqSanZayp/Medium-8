using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._3
{
    class Bag
    {
        private List<Item> _items;
        private uint _maxWeidth;

        public Bag(List<Item> items, int maxWeidth)
        {
            _items = items;

            if (maxWeidth <= 0)
                throw new InvalidOperationException();

            _maxWeidth = (uint)maxWeidth;
        }

        public int MaxWeidth() => (int)_maxWeidth;
        public IReadOnlyCollection<Item> GetAllItems() => _items.AsReadOnly();

        public void AddItem(string name, int count)
        {
            int currentWeidth = _items.Sum(item => item.Count());
            Item targetItem = _items.FirstOrDefault(item => item.Name == name);

            if (targetItem == null)
                throw new InvalidOperationException();

            if (currentWeidth + count > _maxWeidth)
                throw new InvalidOperationException();

            targetItem.Add(count);
        }
        
    }

    class Item
    {
        public string Name { get; private set; }
        private uint _count;

        public Item(string name, int count)
        {
            Name = name;
            if(count <= 0)
                throw new InvalidOperationException();

            _count = (uint)count;
        }

        public int Count() => (int)_count;

        public void Add(int count)
        {
            if(count <= 0)
                throw new InvalidOperationException();

            _count = (uint)count;
        }
    }
}
