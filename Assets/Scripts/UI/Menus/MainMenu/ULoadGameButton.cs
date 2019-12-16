//FILE          :   ULoadGameButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   12/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : ULoadGameButton
//PURPOSE : calls the function to open the load menu
public class ULoadGameButton : UIButton
{
    //Function : Clicked
    //DESCRIPTION : calls the function in the UI event manager to open the load menu
    // and closes the main menu
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerCloseMainMenu();
        UIEventManager.TriggerOpenLoadMenu();
    }
}
