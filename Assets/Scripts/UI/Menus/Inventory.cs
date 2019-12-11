﻿//FILE          :   Inventory.cs
//PROJECT       :   Will of the Woods
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   11/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : MInventory
//PURPOSE : serves as the inventory menu
public class MInventory : Menu
{

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Start()
    {
        UIEventManager.OpenInventory += OpenMenu;
        UIEventManager.CloseInventory += CloseMenu;
    }
}
