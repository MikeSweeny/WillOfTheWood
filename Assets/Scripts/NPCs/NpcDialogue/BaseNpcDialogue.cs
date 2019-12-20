//FILE: BaseNpcDialogue.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 19/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//NAME: BaseNpcDialogue
//PURPOSE: this class will serve as the base scriptable object for the generic Npcs
public class BaseNpcDialogue : ScriptableObject
{
    public string preReqStatName1;
    public string preReqStatName2;

    public int numInStatReq1;
    public int numInStatReq2;

    [TextArea(3, 10)]
    public string welcomeText;
    [TextArea(3, 10)]
    public string conversationText;
    [TextArea(3, 10)]
    public string goodbyeText;

    public virtual void Welcome() { }
    public virtual void Conversation() { }
    public virtual void Goodbye() { }
}
