//FILE          :   Quest.cs
//PROJECT       :   Will of the Woods
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
        UIEventManager.OpenQuests += OpenMenu;
        UIEventManager.CloseQuests += CloseMenu;
    }

}
