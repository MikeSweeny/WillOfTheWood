//FILE          :   UQuestMenuButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   13/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UQuestMenuButton
//PURPOSE : Opens the quest menu
public class UQuestMenuButton : UIButton
{
    //Function : Clicked
    //DESCRIPTION : Calls the function in the UI event manager that closes the pause menu
    // and opens the quest menu
    //PARAMETERS :  none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerClosePause();
        UIEventManager.TriggerQuestsOpen();
    }
}
