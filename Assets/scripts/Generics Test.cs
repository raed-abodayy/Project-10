using System.Collections;
using System.Collections.Generic;
using assignment18_2;
using Unity.VisualScripting;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    GameContainer<string> GenericsTest1 = new GameContainer<string>("Healing potion");
    void Start()
    {

        GenericsTest1.GetItem();
        GameUtils.DescribeItem<string>("Healing potion");
    }


}
