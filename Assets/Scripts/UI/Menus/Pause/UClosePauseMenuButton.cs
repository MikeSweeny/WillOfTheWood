//FILE          :   UClosePauseMenuButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   31/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UClosePauseMenuButton
//PURPOSE : calls the function that closes the pause menu
public class UClosePauseMenuButton : UIButton
{
    //Function : Clicked
    //DESCRIPTION : Calls the function in the UI event manager that closes the pause menu
    //PARAMETERS :  none
    //RETURNS : none
    public override void Clicked()
    {
        GameEventManager.TriggerUnPause();
    }
}
