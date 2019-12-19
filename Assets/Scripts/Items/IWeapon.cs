//FILE          :   IWeapon.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   18/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : IWeapon
//PURPOSE : the base class for weapons
public class IWeapon : Item
{

    //Function : IWeapon
    //DESCRIPTION : Initializes the weapon
    //PARAMETERS : none
    //RETURNS : IWeapon : the item that was constructed
    public IWeapon()
    {
        itemType = ItemTypes.WEAPON;
    }
}
