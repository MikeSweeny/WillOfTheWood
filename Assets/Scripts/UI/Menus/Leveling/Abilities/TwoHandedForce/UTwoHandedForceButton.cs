﻿//FILE          :   UTwoHandedForceButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   09/01/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UTwoHandedForceButton
//PURPOSE : sets the selected ability in the 
//leveling menu to the TwoHandedForce ability
public class UTwoHandedForceButton : UAbilitySlotButton
{
    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    private void Awake()
    {
        ability = new TwoHandedForce();
    }
}
