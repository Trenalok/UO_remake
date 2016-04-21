using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Scripts.Items
{

    public class BagItem
    {
        public Vector2 packLocation;
        public Item item;

    }

    public class Backpack : MonoBehaviour
    {

        public List<BagItem> Items;
        public Backpack()
        {
            Items = new List<BagItem>();
        }

        public void PrintAllItems()
        {
            int i = 0;
            foreach (BagItem it in Items)
            {

                print("Item Number: " + i + "Item Type: " + it.item.Description);
                i++;
            }
        }
    }
}
