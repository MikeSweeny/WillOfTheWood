//FILE          :   ULevelingMenuButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   13/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : ULevelingMenuButton
//PURPOSE : Opens the leveling menu
public class ULevelingMenuButton : UIButton
{

    //Function : Clicked
    //DESCRIPTION : calls the function in the UI event manager that opens the leveling menu
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        UIEventManager.TriggerClosePause();
        UIEventManager.TriggerOpenLeveling();
    }
}
