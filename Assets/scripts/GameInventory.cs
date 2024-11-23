using System.Collections;
using System.Collections.Generic;
using assignment18_2;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    void Start()
    {
Inventory potions=new Inventory();
Inventory elixir=new Inventory();
potions.AddItem("healing potion");
potions.AddItem("strengthpotion");
elixir.AddItem("Elixir");
elixir.AddItem("Dark Elixir");
Inventory combinenewinventories=potions+elixir;
combinenewinventories.ShowItem();


    }


}
