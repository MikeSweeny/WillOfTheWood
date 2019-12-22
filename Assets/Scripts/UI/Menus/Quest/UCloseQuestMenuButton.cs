//FILE          :   UCloseQuestMenuButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   22/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UCloseQuestMenuButton
//PURPOSE : calls the function that closes the quest menu
public class UCloseQuestMenuButton : UIButton
{
    //Function : Clicked
    //DESCRIPTION : calls the function in the ui event manager that closes the 
    // quest menu and opens the pause menu
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerQuestsClose();
        UIEventManager.TriggerOpenPause();
    }
}
