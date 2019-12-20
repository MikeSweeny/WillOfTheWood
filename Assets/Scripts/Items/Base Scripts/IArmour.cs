//FILE          :   IArmour.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   18/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : IArmour
//PURPOSE : the base class for armour items
public class IArmour : Item
{
    protected ArmorStats stats;
    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    public void Awake()
    {
        itemType = ItemTypes.ARMOUR;
    }
    public ArmorStats GetStats()
    {
        return stats;
    }
}
