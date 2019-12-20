//FILE: ConversationNpc.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 19/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME: ConversationNpc
//PURPOSE: this class is used for generic npcs that the player can talk to that may not have significance to the game
public class ConversationNpc : BaseInteractableNpc, IQuestID
{

    public List<BaseNpcDialogue> dialogueList = new List<BaseNpcDialogue>();
    public BaseNpcDialogue dialogue { get; set; }
    public string ID { get; set; }
    public Button nextButton;

    public string IDName;
    public bool isPartOfQuest = false;
    private bool isTalking = false;
    private bool hasBeenTalkedTo = false;

    private void Awake()
    {
        ID = IDName;
    }

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

    private void NextDialogue()
    {

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

    public void Cleared()
    {
        hasBeenTalkedTo = true;
        QuestEvents.ItemCleared(this);
    }
}
