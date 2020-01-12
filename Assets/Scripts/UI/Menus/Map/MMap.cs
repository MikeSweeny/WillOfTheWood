using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMap : Menu
{
    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    private void Awake()
    {
        UIEventManager.OpenMapMenu += OpenMenu;
        UIEventManager.CloseMapMenu += CloseMenu;
    }
}
