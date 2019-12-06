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
    public static event InputEvent Attack;

    public static event InputEvent Ability1;
    public static event InputEvent Ability2;
    public static event InputEvent Ability3;
    public static event InputEvent Ability4;
    public static event InputEvent Ability5;
    public static event InputEvent Ability6;
    public static event InputEvent Ability7;
    public static event InputEvent Ability8;
    public static event InputEvent Ability9;
    public static event InputEvent Ability0;

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

    //Function: TriggerRotate
    //DESCRIPTION: Calls the event for rotating left or right
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerRotate()
    {
        if (Input.GetAxis("Horizontal") != 0)
            Rotate();

    }

}
