//FILE: BaseInteractableNpc.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 12/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//NAME: BaseInteractableNpc
//PURPOSE: this class will act as the base for all functionality shared between shop NPCs and Quest Giver NPCs
public abstract class BaseInteractableNpc : BaseNpc
{
    
    //Function: OnInteract
    //DESCRIPTION: this function is used for overriding in children to say what is supposed to happen when they are interacted with
    //PARAMETERS: None
    //RETURNS: None
    public abstract void OnInteract();

}
