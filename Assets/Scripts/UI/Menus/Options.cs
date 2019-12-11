﻿//FILE          :   Options.cs
//PROJECT       :   Will of the Woods
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   11/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : MOptions
//PURPOSE : Serves as the options menu
public class MOptions : Menu
{

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        UIEventManager.OpenOptions += OpenMenu;
        UIEventManager.CloseOptions += CloseMenu;
    }


    //Function : Update
    //DESCRIPTION : called once per frame
    //PARAMETERS : none
    //RETURNS : none
    void Update()
    {
        
    }
}