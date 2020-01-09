﻿//FILE: BaseInteractableNpc.cs
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
    protected string currentText;
    protected Player player;
    protected bool isActive;
    protected Transform myTransform;

    //Function: OnInteract
    //DESCRIPTION: this function is used for overriding in children to say what is supposed to happen when they are interacted with
    //PARAMETERS: None
    //RETURNS: None

    private void Start()
    {
        myTransform = transform;
    }
    public abstract void OnInteract();
    public abstract void NextDialogue();

    public virtual string GetCurrentText()
    {
        return currentText;
    }

    public void Update()
    {
        LookAt();
        DialogeBox();
    }

    public virtual void DialogeBox()
    {
        if(isActive)
        {
            player = FindObjectOfType<Player>();
            if (player)
            {
                if (Vector2.Distance(transform.position, player.transform.position) >= 2)
                {
                    UIEventManager.TriggerCloseDialogue();
                    isActive = false;
                }
            }
        }
    }
    public void LookAt()
    {
        player = FindObjectOfType<Player>();
        if (player)
        {
            if (Vector2.Distance(transform.position, player.transform.position) <= 1)
            {
                transform.LookAt(player.transform);
            }
            else
            {
                transform.rotation = myTransform;
            }
        }
    }
}
