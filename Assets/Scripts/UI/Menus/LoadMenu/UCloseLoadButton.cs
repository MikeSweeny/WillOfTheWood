//FILE          :   UCloseLoadButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   17/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UCloseLoadButton
//PURPOSE : closes the load menu
public class UCloseLoadButton : UIButton
{

    //Function : Clicked
    //DESCRIPTION : calls the function in the UI event manager that opens the options menu
    // and closes the load menu
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerCloseLoadMenu();
        UIEventManager.TriggerOpenMainMenu();
    }
}
