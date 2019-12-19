//FILE          :   IMiscellanious.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   18/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : IMiscellanious
//PURPOSE : the base class of all miscellanious items
public class IMiscellanious : Item
{

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    public void Awake()
    {
        itemType = ItemTypes.MISC;
    }
}
