//FILE          :   UCloseAudioButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   16/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UCloseAudioButton
//PURPOSE : calls the function that closes the audio menu
public class UCloseAudioButton : UIButton
{

    //Function : Clicked
    //DESCRIPTION : calls the function in the UI event manager that opens the options menu
    // and closes the audio menu
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerCloseAudioMenu();
        UIEventManager.TriggerOptionsOpen();
    }
}
