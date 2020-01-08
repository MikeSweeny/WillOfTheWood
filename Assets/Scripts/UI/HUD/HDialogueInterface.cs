﻿//FILE          :   HDialogueInterface.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   20/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//NAME : HDialogueInterface
//PURPOSE : serves as the dialogue interface
public class HDialogueInterface : HUDElement
{
    public Text dialogueText { get; set; }
    private UNextDialogueButton button;

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    private void Awake()
    {
        dialogueText = transform.Find("Text").GetComponent<Text>();
        button = transform.Find("NextButton").GetComponent<UNextDialogueButton>();
        UIEventManager.OpenDialogue += Open;
        UIEventManager.CloseDialogue += Close;
        gameObject.SetActive(false);
    }

    //Function : UpdateElement
    //DESCRIPTION : Updates the relevant information to the element
    //PARAMETERS : none
    //RETURNS : none
    public override void UpdateElement()
    {
        GameObject playerTarget = player.FindPlayerTarget();
        if (playerTarget != null && playerTarget.CompareTag("NPC"))
        { 
            if (playerTarget.GetComponent<ConversationNpc>())
            {
                ConversationNpc target = playerTarget.GetComponent<ConversationNpc>();
                dialogueText.text = target.GetCurrentText();
                button.SetTarget(target);
            }
            else if(playerTarget.GetComponent<QuestGiverNpc>())
            {
                QuestGiverNpc Qtarget = playerTarget.GetComponent<QuestGiverNpc>();
                dialogueText.text = Qtarget.GetCurrentText();
                button.QSetTarget(Qtarget);
            }
        }
    }

    //Function : Open
    //DESCRIPTION : opens the dialogue interface
    //PARAMETERS : none
    //RETURNS : none
    private void Open()
    {
        gameObject.SetActive(true);
    }

    //Function : Close
    //DESCRIPTION : closes the dialogue interface
    //PARAMETERS : none
    //RETURNS : none
    private void Close()
    {
        gameObject.SetActive(false);
    }

    //Function : OnDestroy
    //DESCRIPTION : Called when the object is destroyed
    //PARAMETERS : none
    //RETURNS : none
    private void OnDestroy()
    {
        UIEventManager.OpenDialogue -= Open;
        UIEventManager.CloseDialogue -= Close;
    }
}
