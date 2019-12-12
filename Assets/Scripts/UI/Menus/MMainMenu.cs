//FILE          :   MMainMenu.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   11/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : MMainMenu
//PURPOSE : serves as the main menu
public class MMainMenu : Menu
{

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        UIEventManager.OpenMainMenu += OpenMenu;
        UIEventManager.CloseMainMenu += CloseMenu;
    }
}
