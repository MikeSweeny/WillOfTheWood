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

    //Function : IArmour
    //DESCRIPTION : Initializes the armour
    //PARAMETERS : none
    //RETURNS : IArmour : the item that was constructed
    public IArmour()
    {
        itemType = ItemTypes.ARMOUR;
    }
}
