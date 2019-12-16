//FILE          :   MQuest.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   11/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : MQuest
//PURPOSE : serves as the quest menu
public class MQuest : Menu
{

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        gameObject.SetActive(false);
        UIEventManager.OpenQuests += OpenMenu;
        UIEventManager.CloseQuests += CloseMenu;
    }

    //Function : OnDestroy
    //DESCRIPTION : Called when the object is destroyed
    //PARAMETERS : none
    //RETURNS : none
    private void OnDestroy()
    {
        UIEventManager.OpenQuests -= OpenMenu;
        UIEventManager.CloseQuests -= CloseMenu;
    }

}
