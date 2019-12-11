﻿//FILE          :   Shop.cs
//PROJECT       :   Will of the Woods
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   11/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : MShop
//PURPOSE : serves as the shop menu
public class MShop : Menu
{

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        UIEventManager.OpenShop += OpenMenu;
        UIEventManager.CloseShop += CloseMenu;
    }
}