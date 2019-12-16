//FILE          :   UNewGameButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   12/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UNewGameButton
//PURPOSE : calls the function to open the save menu
public class UNewGameButton : UIButton
{

    //Function : Clicked
    //DESCRIPTION : Calls the function in the UI event manager to open the save menu
    // and closes the main menu
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerCloseMainMenu();
        UIEventManager.TriggerOpenSaveMenu();
    }
}
