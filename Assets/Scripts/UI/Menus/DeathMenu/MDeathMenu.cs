//FILE          :   MDeathMenu.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Michael Sweeny
//FIRST VERSION :   01/06/20
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : MDeathMenu
//PURPOSE : serves as the death menu
public class MDeathMenu : Menu
{
    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    private void Awake()
    {
        UIEventManager.OpenDeathMenu += OpenMenu;
        UIEventManager.CloseDeathMenu += CloseMenu;
    }

    //Function : OnDestroy
    //DESCRIPTION : Called when the object is destroyed
    //PARAMETERS : none
    //RETURNS : none
    private void OnDestroy()
    {
        UIEventManager.OpenDeathMenu -= OpenMenu;
        UIEventManager.CloseDeathMenu -= CloseMenu;
    }
}
