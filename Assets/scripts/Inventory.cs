using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment18_2
{
    public class Inventory
    {
        private List<string> list1 = new List<string>();
        public void AddItem(string item)
        {
            list1.Add(item);
        }
        public void ShowItem()
        {
            foreach (string item in list1)
            {
                Debug.Log(item);
            }
        }


        public static Inventory operator +(Inventory a, Inventory b)
        {
            Inventory combined = new Inventory();
            foreach (string item in a.list1)
            {
                combined.AddItem(item);
            }
            foreach (string item in b.list1)
            {
                combined.AddItem(item);
            }
            return combined;
        }
    }

}
