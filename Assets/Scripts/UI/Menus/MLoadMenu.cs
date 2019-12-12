//FILE          :   MLoadMenu.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   12/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : MLoadMenu
//PURPOSE : serves as the load menu
public class MLoadMenu : Menu
{

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        UIEventManager.OpenLoadMenu += OpenMenu;
        UIEventManager.CloseLoadMenu += CloseMenu;
    }
}
