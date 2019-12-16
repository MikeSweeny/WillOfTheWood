//FILE          :   UCloseVideoButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   16/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UCloseVideoButton
//PURPOSE : calls the function that closes the video menu
public class UCloseVideoButton : UIButton
{

    //Function : Clicked
    //DESCRIPTION : calls the function in the UI event manager that opens the options menu
    // and closes the video menu
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerCloseVideoMenu();
        UIEventManager.TriggerOptionsOpen();
    }
}
