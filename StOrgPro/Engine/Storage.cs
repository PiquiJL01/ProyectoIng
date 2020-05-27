using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Storage
    {
        public int ID { get; set; }
        public string Name { get; set; }
        int[] Dimensions = new int[2];
        private List<Item> Inventory = new List<Item>();
        private Dictionary<Item, int> ItemCount = new Dictionary<Item, int>();

        public Storage(int id, string name, int length, int width)
        {
            ID = id;
            Name = name;
            Dimensions[1] = length;
            Dimensions[2] = width;
        }

        public void AddItem(Item item, int quantity = 0)
        {
            if (Inventory.Contains(item))
            {
                ItemCount[item] = +quantity;
            }
            else
            {
                Inventory.Add(item);
                ItemCount.Add(item, quantity);
            }
        }

        public void RemoveItem(Item item, int quantity)
        {
            if (Inventory.Contains(item))
            {
                if (quantity == 0)
                {
                    ItemCount[item] = quantity;
                }
            }
        }
    }
}
