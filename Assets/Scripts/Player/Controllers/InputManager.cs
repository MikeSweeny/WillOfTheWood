//FILE: InputManager.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME: InputManager
//PURPOSE: This class is meant to act as an intermediary
// between the default input manager and our controllers.
public class InputManager : MonoBehaviour
{

    public delegate void InputEvent();

    public static event InputEvent Jump;
    public static event InputEvent Walk;
    public static event InputEvent Interact;
    public static event InputEvent Rotate;

    //Function: TriggerJump
    //DESCRIPTION: Calls the event for jumping
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerJump()
    {
        if (Input.GetButtonDown("Jump"))
            Jump();
    }

    //Function: TriggerWalk
    //DESCRIPTION: Calls the event for walking forward / backward
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerWalk()
    {
        if (Input.GetAxis("Vertical") != 0)
            Walk();
    }

    //Function: TriggerInteract
    //DESCRIPTION: Calls the event for interacting
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerInteract()
    {
        if (Input.GetButtonDown("Interact"))
            Interact();
    }

}
