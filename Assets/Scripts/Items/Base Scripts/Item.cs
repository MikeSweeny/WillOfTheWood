﻿//FILE          :   Item.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   18/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : Item
//PURPOSE : represents anything that can exist in an inventory
public abstract class Item : MonoBehaviour
{
    protected ItemTypes itemType;

    protected Image itemSprite;

    public int ItemCost;

    public bool isBought = false;
    public bool isSold = false;
    //Function : GetSprite
    //DESCRIPTION : retrieves the item sprite
    //PARAMETERS : none
    //RETURNS : Image itemSprite : the sprite image for the item
    public Image GetSprite()
    {
        return itemSprite;
    }
    public bool Bought()
    {
        return isBought;
    }
    public bool Sold()
    {
        return isSold;
    }
    public abstract void Use();
}
