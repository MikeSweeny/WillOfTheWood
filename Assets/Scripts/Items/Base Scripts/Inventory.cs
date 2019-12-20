//FILE          :   Inventory.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   18/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : Inventory
//PURPOSE : contains all the items the character is carrying
public class Inventory : MonoBehaviour
{

    private List<Item> contents;

    private int currency;

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        contents = new List<Item>();
    }

    //Function : AddItem
    //DESCRIPTION : adds the provided item to the inventory's contents
    //PARAMETERS : Item item : the item to add to the list
    //RETURNS : none
    public void AddItem(Item item)
    {
        contents.Add(item);
    }

    //Function : RemoveItem
    //DESCRIPTION : removes the provided item from the inventory's contents
    //PARAMETERS : Item item : the item to remove from the list
    //RETURNS : none
    public void RemoveItem(Item item)
    {
        contents.Remove(item);
    }

    private void AddCurrency(int amount)
    {
        currency += amount;
    }

    private int GetCurrency()
    {
        return currency;
    }

    private void RemoveCurrency(int amount)
    {
        AddCurrency(-amount);
    }
}
