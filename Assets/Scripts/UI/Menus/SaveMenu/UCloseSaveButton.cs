//FILE          :   UCloseSaveButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   17/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UCloseSaveButton
//PURPOSE : closes the save menu
public class UCloseSaveButton : UIButton
{

    //Function : Clicked
    //DESCRIPTION : calls the function in the UI event manager that opens the options menu
    // and closes the save menu
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerCloseSaveMenu();
        UIEventManager.TriggerOpenMainMenu();
    }
}
