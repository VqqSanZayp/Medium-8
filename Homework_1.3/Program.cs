using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._3
{
    class Bag
    {
        private List<Item> Items;
        public int MaxWeidth { get; private set; }

        public Bag(List<Item> items, int maxWeidth)
        {
            Items = items;

            if (maxWeidth <= 0)
                throw new InvalidOperationException();

            MaxWeidth = maxWeidth;
        }

        public IReadOnlyCollection<Item> GetAllItems() => Items.AsReadOnly();

        public void AddItem(string name, int count)
        {
            int currentWeidth = Items.Sum(item => item.Count);
            Item targetItem = Items.FirstOrDefault(item => item.Name == name);

            if (targetItem == null)
                throw new InvalidOperationException();

            if (currentWeidth + count > MaxWeidth)
                throw new InvalidOperationException();

            targetItem.Add(count);
        }
        
    }

    class Item
    {
        public string Name { get; private set; }
        public int Count { get; private set; }

        public Item(string name, int count)
        {
            Name = name;
            Count = count;
        }

        public void Add(int count) => Count += count;
    }
}
