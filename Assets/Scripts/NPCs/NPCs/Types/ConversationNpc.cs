//FILE: ConversationNpc.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 19/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME: ConversationNpc
//PURPOSE: this class is used for generic npcs that the player can talk to that may not have significance to the game
public class ConversationNpc : BaseInteractableNpc
{

    public List<BaseNpcDialogue> dialogueList = new List<BaseNpcDialogue>();
    public BaseNpcDialogue dialogue { get; set; }

    private bool isTalking = false;

    //Function: OnInteract
    //DESCRIPTION: overriden function from parent class
    //PARAMETERS: None
    //RETURNS: None
    public override void OnInteract()
    {
        if(!isTalking)
        {
            StartTalking();
        }
    }

    //Function: StartTalking
    //DESCRIPTION: this function will be used to start generic conversations
    //PARAMETERS: None
    //RETURNS: None
    private void StartTalking()
    {
        for (int i = 0; i < dialogueList.Count; i++)
        {
            dialogue = dialogueList[i];

            dialogue.Welcome();
            isTalking = true;
            return;
        }
    }

}
