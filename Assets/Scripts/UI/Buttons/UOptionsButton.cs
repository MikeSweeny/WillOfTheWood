//FILE          :   UOptionsButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   12/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UOptionsButton
//PURPOSE : calls the function to open the options menu
public class UOptionsButton : UIButton
{

    //Function : Clicked
    //DESCRIPTION : Calls the function in the UI event manager that opens the options menu
    // and closes the main menu
    //PARAMETERS :  none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerCloseMainMenu();
        UIEventManager.TriggerClosePause();
        UIEventManager.TriggerOptionsOpen();
    }
}
