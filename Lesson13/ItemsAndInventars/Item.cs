using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.ItemsAndInventars
{
    public class Item
    {
        private string _itemName;
        private ItemType Type { get; set; }
        private int _price;
        private int _weight;

        public string ItemName
        {
            get { return _itemName; }
            set
            {
                if (value is null) throw new ArgumentException("Неверное имя предмета.");
                else _itemName = value;
            }
        }

        public int Price
        {
            get { return _price; }
            private set
            {
                if (value >= 0) _price = value;
                else throw new ArgumentException("Неверная цена предмета");
            }
        }

        public int Weight
        {
            get { return _weight; }
            set
            {
                if (value >= 0) _weight = value;
                else throw new ArgumentException("Неверный вес предмета");
            }
        }

        public Item(string itemName, ItemType type, int price, int weight)
        {
            ItemName = itemName;
            Type = type;
            Price = price;
            Weight = weight;
        }
    }
}
