//FILE          :   UNextDialogueButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   20/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UNextDialogueButton
//PURPOSE : moves the dialogue forward
public class UNextDialogueButton : UIButton
{

    private BaseInteractableNpc target;


    //Function : Clicked
    //DESCRIPTION : sets the current slot string to the name of the parent containing this button
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        if (target)
            target.NextDialogue();
        target = null;


    }

    //Function : SetTarget
    //DESCRIPTION :
    //PARAMETERS :
    //RETURNS : 
    public void SetTarget(BaseInteractableNpc nTarget)
    {
        target = nTarget;
    }

}
