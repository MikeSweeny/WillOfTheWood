//FILE          :   IConsumable.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   18/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : IConsumable
//PURPOSE : the base class for consumable items
public class IConsumable : Item
{

    //Function : IConsumable
    //DESCRIPTION : Initializes the consumable
    //PARAMETERS : none
    //RETURNS : IConsumable : the item that was constructed
    public IConsumable()
    {
        itemType = ItemTypes.CONSUMABLE;
    }
}
