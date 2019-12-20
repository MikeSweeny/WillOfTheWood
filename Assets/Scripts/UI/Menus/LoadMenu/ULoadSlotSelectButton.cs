//FILE          :   ULoadSlotSelectButton
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   13/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//NAME : ULoadSlotSelectButton
//PURPOSE : sets the desired slot for saving in the GameSaveManager and starts the game
public class ULoadSlotSelectButton : UIButton
{

    //Function : Clicked
    //DESCRIPTION : sets the current slot string to the name of the parent containing this button
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        GameSaveManager.SetCurrentSlot(transform.parent.name);
        SceneManager.LoadScene("CoreScene");
    }
}
