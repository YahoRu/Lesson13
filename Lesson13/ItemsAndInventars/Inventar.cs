using Lesson13.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.ItemsAndInventars
{
    public class Inventar
    {
        private readonly List<Item> items;

        private string _owner;
        private int _maxSize;
        private int _size;

        public string Owner
        {
            get { return _owner; }
            set
            {
                if (value is null) throw new ArgumentException("У инвентаря должен быть владалец.");
                else _owner = value;
            }
        }

        public int MaxSize
        {
            get { return _maxSize; }
            set
            {
                if (value < 10) throw new ArgumentException("Неверный максимальный размер инвентаря.");
                else _maxSize = value;
            }
        }

        public int Size
        {
            get { return _size; }
            set
            {
                if (value > MaxSize && value < 1) throw new ArgumentException("Неверный размер инвентаря.");
                else _size = value;
            }
        }

        public Inventar(Creature creature, int maxSize, int size)
        {
            items = new List<Item>();
            Owner = creature.Name;
            MaxSize = maxSize;
            Size = size;
        }

        public void AddItem(Item item)
        {
            if (Size < MaxSize)
            {
                items.Add(item);
                Size++;
            }
            else throw new ArgumentException("Недостаточно места в инвентаре.");
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }
    }
}
