using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assignment18_2
{
    public class GameContainer<T>
    {
        public T v;
        public GameContainer(T item)
        {
            this.v = item;

        }
        public void SetItem(T item)
        {
            this.v = item;

        }
        public void GetItem()
        {
            Debug.Log(v);
        }
    }
    public class GameUtils
    {
        public static void DescribeItem<T>(T something)
        {
            Debug.Log("this item is:" + something);
        }
    }
}