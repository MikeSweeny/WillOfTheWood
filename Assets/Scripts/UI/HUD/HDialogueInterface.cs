//FILE          :   HDialogueInterface.cs
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
    private Text dialogueText;
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
    }

    //Function : UpdateElement
    //DESCRIPTION : Updates the relevant information to the element
    //PARAMETERS : none
    //RETURNS : none
    public override void UpdateElement()
    {
        ConversationNpc target = player.GetPlayerTarget().GetComponent<ConversationNpc>();
        dialogueText.text = target.GetCurrentText();
        button.SetTarget(target);
    }

    //Function : Open
    //DESCRIPTION : opens the dialogue interface
    //PARAMETERS : none
    //RETURNS : none
    private void Open()
    {
        gameObject.SetActive(false);
    }

    //Function : Close
    //DESCRIPTION : closes the dialogue interface
    //PARAMETERS : none
    //RETURNS : none
    private void Close()
    {
        gameObject.SetActive(true);
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
