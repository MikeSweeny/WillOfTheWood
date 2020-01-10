//FILE          :   Menu.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   11/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : Menu
//PURPOSE : Parent of all the menu classes
public class Menu : MonoBehaviour
{

    //Function : OpenMenu
    //DESCRIPTION : Activates the menu to "open" it
    //PARAMETERS : none
    //RETURNS : none
    protected void OpenMenu()
    {
        InputManager.RefocusEventSystem(this);
        gameObject.SetActive(true);
    }

    //Function : CloseMenu
    //DESCRIPTION : Deactivates the menu to "close" it
    //PARAMETERS : none
    //RETURNS : none
    protected void CloseMenu()
    {
        gameObject.SetActive(false);
    }
}
