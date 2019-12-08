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
// there must be an instance of this class in the game for the input to work
public class InputManager : MonoBehaviour
{

    private static InputManager instance = null;
    public static InputManager Instance { get { return instance; } }

    public delegate void InputEvent();
    public delegate void WalkInputEvent(float verticalValue);
    public delegate void RotateInputEvent(float horizontalValue);
    public delegate void CamerControlEvent();

    public static event InputEvent Jump;
    public static event InputEvent Interact;
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

    public static event WalkInputEvent Walk;
    public static event RotateInputEvent Rotate;
    public static event CamerControlEvent MoveCamera;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
    }

    private void Update()
    {
        TriggerJump();
        MoveCamera?.Invoke();
        TriggerAttack();
    }

    private void FixedUpdate()
    {
        Walk?.Invoke(Input.GetAxis("Vertical"));

        Rotate?.Invoke(Input.GetAxis("Horizontal"));
    }

    //Function: TriggerJump
    //DESCRIPTION: Calls the event for jumping
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerJump()
    {
        if (Input.GetButtonDown("Jump"))
            Jump?.Invoke();
    }

    //Function: TriggerInteract
    //DESCRIPTION: Calls the event for interacting
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerInteract()
    {
        if (Input.GetButtonDown("Interact"))
            Interact?.Invoke();
    }

    //Function: TriggerAttack
    //DESCRIPTION: Calls the event for attacking
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerAttack()
    {
        if(Input.GetMouseButtonDown(0))
            Attack?.Invoke();

    }

    //Function: TriggerAbility1
    //DESCRIPTION: Calls the event for the ability in the 1 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerAbility1()
    {
        if(Input.GetButtonDown("Ability1"))
            Ability1?.Invoke();
    }

    //Function: TriggerAbility2
    //DESCRIPTION: Calls the event for the ability in the 2 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerAbility2()
    {
        if (Input.GetButtonDown("Ability2"))
            Ability2?.Invoke();
    }

    //Function: TriggerAbility3
    //DESCRIPTION: Calls the event for the ability in the 3 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerAbility3()
    {
        if (Input.GetButtonDown("Ability3"))
            Ability3?.Invoke();
    }

    //Function: TriggerAbility4
    //DESCRIPTION: Calls the event for the ability in the 4 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerAbility4()
    {
        if (Input.GetButtonDown("Ability4"))
            Ability4?.Invoke();
    }

    //Function: TriggerAbility5
    //DESCRIPTION: Calls the event for the ability in the 5 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerAbility5()
    {
        if (Input.GetButtonDown("Ability5"))
            Ability5?.Invoke();
    }

    //Function: TriggerAbility6
    //DESCRIPTION: Calls the event for the ability in the 6 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerAbility6()
    {
        if (Input.GetButtonDown("Ability6"))
            Ability6?.Invoke();
    }

    //Function: TriggerAbility7
    //DESCRIPTION: Calls the event for the ability in the 7 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerAbility7()
    {
        if (Input.GetButtonDown("Ability7"))
            Ability7?.Invoke();
    }

    //Function: TriggerAbility8
    //DESCRIPTION: Calls the event for the ability in the 8 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerAbility8()
    {
        if (Input.GetButtonDown("Ability8"))
            Ability8?.Invoke();
    }

    //Function: TriggerAbility9
    //DESCRIPTION: Calls the event for the ability in the 9 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerAbility9()
    {
        if (Input.GetButtonDown("Ability9"))
            Ability9?.Invoke();
    }

    //Function: TriggerAbility0
    //DESCRIPTION: Calls the event for the ability in the 0 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerAbility0()
    {
        if (Input.GetButtonDown("Ability0"))
            Ability0?.Invoke();
    }
}
