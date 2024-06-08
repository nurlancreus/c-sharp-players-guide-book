using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_part3.Challange1.Entities.BaseModel
{
    internal enum Item
    {
        Arrow = 1,
        Bow,
        Rope,
        Water,
        Food,
        Sword
    }

    internal class InventoryItem
    {
        private string _name = string.Empty;
        private float _weight;
        private float _volume;

        public InventoryItem(Item item)
        {
            _name = item.ToString();

            switch (item)
            {

                case Item.Arrow:
                    Weight = 0.1f;
                    Volume = 0.05f;
                    break;
                case Item.Bow:
                    Weight = 1;
                    Volume = 4;
                    break;
                case Item.Rope:
                    Weight = 1;
                    Volume = 1.5f;
                    break;
                case Item.Water:
                    Weight = 2;
                    Volume = 3;
                    break;
                case Item.Food:
                    Weight = 1;
                    Volume = 0.5f;
                    break;
                case Item.Sword:
                    Weight = 5;
                    Volume = 3;
                    break;
            }
        }
        public float Weight
        {
            get { return _weight; }
            set
            {
                if (CheckValue(value, "weigth")) _weight = value;

            }
        }

        public float Volume
        {
            get { return _volume; }
            set
            {
                if (CheckValue(value, "volume")) _volume = value;

            }
        }

        private static bool CheckValue(float value, string data)
        {
            while (true)
            {
                try
                {
                    if (value <= 0) throw new ArgumentOutOfRangeException($"An item's ${data} can not be zero or negative");
                    else return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
