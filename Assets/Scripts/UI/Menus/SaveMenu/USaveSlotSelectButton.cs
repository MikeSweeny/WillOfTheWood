//FILE          :   USaveSlotSelectButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   13/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//NAME : USaveSlotSelectButton
//PURPOSE : selects the slot the player would like their new game to save in
public class USaveSlotSelectButton : UIButton
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
