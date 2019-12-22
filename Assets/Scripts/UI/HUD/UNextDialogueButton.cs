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

    private ConversationNpc target;
    private QuestGiverNpc Qtarget;

    //Function : Clicked
    //DESCRIPTION : sets the current slot string to the name of the parent containing this button
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        //needs a method that will allow for the button to be set in the NPC or something, 
        //cause if you visit a conversation NPC, then a quest NPC, it wants to use the ConversationNPC button info

        if (target)
            target.NextDialogue();
        else if (Qtarget)
            Qtarget.NextDialogue();

    }

    //Function : SetTarget
    //DESCRIPTION :
    //PARAMETERS :
    //RETURNS : 
    public void SetTarget(ConversationNpc nTarget)
    {
        target = nTarget;
    }

    public void QSetTarget(QuestGiverNpc nTarget)
    {
        Qtarget = nTarget;
    }
}
