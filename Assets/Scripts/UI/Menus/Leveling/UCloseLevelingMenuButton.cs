//FILE          :   UCloseLevelingMenuButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   22/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UCloseLevelingMenuButton
//PURPOSE : calls the function that closes the leveling menu
public class UCloseLevelingMenuButton : UIButton
{

    //Function : Clicked
    //DESCRIPTION : calls the function in the ui event manager that closes the 
    // leveling menu and opens the pause menu
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerCloseLeveling();
        UIEventManager.TriggerOpenPause();
    }
}
