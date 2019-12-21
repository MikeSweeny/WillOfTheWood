//FILE: NormalDialogue.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 19/12/2019
using UnityEngine;

//NAME: NormalDialogue
//PURPOSE: this is the scriptable object responsible for the generic talking of an NPC
[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue/Normal")]
public class NormalDialogue : BaseNpcDialogue
{
   

    public override void Welcome()
    {
        DH = FindObjectOfType<HDialogueInterface>();
        if (DH)
        {
            DH.dialogueText.text = welcomeText;
        }
        Debug.Log(welcomeText);
    }

    public override void Conversation()
    {
        Debug.Log(conversationText);
    }

    public override void Goodbye()
    {
        Debug.Log(goodbyeText);
    }
}
