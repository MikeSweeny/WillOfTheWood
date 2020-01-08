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

    public bool hasBeenTalkedTo = false;
    public string IDName;
    public bool isPartOfQuest = false;
    public bool hasConversation = false;
    private bool isTalking = false; 
    private string currentText = "";

    private void Awake()
    {
        ID = IDName;
        setStats();
    }

    //Function: OnInteract
    //DESCRIPTION: overriden function from parent class
    //PARAMETERS: None
    //RETURNS: None
    public override void OnInteract()
    {
        if (isPartOfQuest && hasBeenTalkedTo)
            return;
        if(!isTalking)
        {
            UIEventManager.TriggerOpenDialogue();
             StartTalking();
        }
    }

    public void NextDialogue()
    {
        if(currentText == dialogue.welcomeText && hasConversation)
        {
            ContinueTalking();
        }
        else if(currentText == dialogue.conversationText || !hasConversation)
        {
            StopTalking();
        }
        else
        {
            isTalking = false;
            UIEventManager.TriggerCloseDialogue();
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
            currentText = dialogue.welcomeText;
            isTalking = true;
            return;
        }
    }

    public string GetCurrentText()
    {
        return currentText;
    }

    private void ContinueTalking()
    {
        currentText = dialogue.conversationText;
        dialogue.Conversation();
        if(isPartOfQuest)
        {
            Cleared();

        }

    }

    private void StopTalking()
    {
        currentText = dialogue.goodbyeText;
        dialogue.Goodbye();
    }

    public void Cleared()
    {
        hasBeenTalkedTo = true;
        QuestEvents.ItemCleared(this);
        Debug.Log("Talked to " + IDName);
    }
}
