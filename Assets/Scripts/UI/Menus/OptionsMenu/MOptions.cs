//FILE          :   MOptions.cs
//PROJECT       :   Will of the Wood
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
    private void Awake()
    {
        gameObject.SetActive(false);
        UIEventManager.OpenOptions += OpenMenu;
        UIEventManager.CloseOptions += CloseMenu;
    }

    //Function : OnDestroy
    //DESCRIPTION : Called when the object is destroyed
    //PARAMETERS : none
    //RETURNS : none
    private void OnDestroy()
    {
        UIEventManager.OpenOptions -= OpenMenu;
        UIEventManager.CloseOptions -= CloseMenu;
    }
}
