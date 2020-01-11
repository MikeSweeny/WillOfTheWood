//FILE: InputManager.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//NAME: InputManager
//PURPOSE: This class is meant to act as an intermediary
// between the default input manager and our controllers.
// there must be an instance of this class in the game for the input to work
public class InputManager : MonoBehaviour
{

    private static InputManager instance = null;
    //public static InputManager Instance { get { return instance; } }

    public delegate void InputEvent();
    public delegate void WalkInputEvent(float verticalValue);
    public delegate void RotateInputEvent(float horizontalValue);
    public delegate void CameraControlEvent();
    public delegate void BumperInputEvent(bool isPressed);

    public static event InputEvent Jump;
    public static event InputEvent Interact;
    public static event InputEvent Attack;
    public static event InputEvent Sprint;
    public static event InputEvent HotbarSlot1;
    public static event InputEvent HotbarSlot2;
    public static event InputEvent HotbarSlot3;
    public static event InputEvent HotbarSlot4;
    public static event InputEvent HotbarSlot5;
    public static event InputEvent HotbarSlot6;
    public static event InputEvent HotbarSlot7;
    public static event InputEvent HotbarSlot8;
    public static event InputEvent HotbarSlot9;
    public static event InputEvent HotbarSlot0;
    public static event InputEvent ControllerHotbarSlot1;
    public static event InputEvent ControllerHotbarSlot2;
    public static event InputEvent ControllerHotbarSlot3;
    public static event InputEvent ControllerHotbarSlot4;

    public static event WalkInputEvent Walk;
    public static event RotateInputEvent Rotate;
    public static event CameraControlEvent MoveCamera;
    public static event BumperInputEvent LeftBumper;
    public static event BumperInputEvent RightBumper;

    //set to false when menu is opened
    public static bool inputEnabled = true;
    private bool axisInUse = false;

    public Texture2D cursorSprite;
    public GameObject dialogueBox;

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
        GameEventManager.Pause += OnPause;
        GameEventManager.UnPause += UnPause;
    }

    private void Update()
    {
        if(inputEnabled)
            MoveCamera?.Invoke();

        if (Input.GetButtonDown("Jump") && dialogueBox.activeInHierarchy == false)
            TriggerJump();

        if (Input.GetButtonDown("Jump") && dialogueBox.activeInHierarchy)
            dialogueBox.GetComponentInChildren<UNextDialogueButton>().Clicked();

        if (Input.GetButtonDown("Fire1") || (Input.GetAxis("ControllerAttack") != 0 && axisInUse == false))
        {
            if (EventSystem.current.IsPointerOverGameObject())
                return;

            TriggerAttack();
            axisInUse = true;
        }

        if (Input.GetButtonDown("LeftBumper"))
            TriggerLeftBumper();

        if (Input.GetButtonDown("RightBumper"))
            TriggerRightBumper();

        if ((Input.GetButtonDown("CHotbarSlot1") && LeftBumper != null) || (Input.GetButtonDown("CHotbarSlot1") && RightBumper != null))
            TriggerControllerHotbarSlot1();

        if ((Input.GetButtonDown("CHotbarSlot2") && LeftBumper != null) || (Input.GetButtonDown("CHotbarSlot2") && RightBumper != null))
            TriggerControllerHotbarSlot2();

        if ((Input.GetButtonDown("CHotbarSlot3") && LeftBumper != null) || (Input.GetButtonDown("CHotbarSlot3") && RightBumper != null))
            TriggerControllerHotbarSlot3();

        if ((Input.GetButtonDown("CHotbarSlot4") && LeftBumper != null) || (Input.GetButtonDown("CHotbarSlot4") && RightBumper != null))
            TriggerControllerHotbarSlot4();

        if (Input.GetButtonDown("WorldMap"))
        {
            //UIEventManager.TriggerOpenMap();
        }
            
        if (Input.GetButtonDown("Inventory"))
            UIEventManager.TriggerOpenLeveling();

        if (Input.GetButtonDown("Cancel"))
        {
            GameEventManager.TriggerPause();
        }
            

        if (Input.GetAxis("ControllerAttack") == 0)
            axisInUse = false;

        if (Input.GetButtonDown("Interact"))
            TriggerInteract();

        if (Input.GetButtonDown("HotbarSlot0"))
            UseHotBarSlot0();

        if (Input.GetButtonDown("HotbarSlot1"))
            UseHotBarSlot1();

        if (Input.GetButtonDown("HotbarSlot2"))
            UseHotBarSlot2();

        if (Input.GetButtonDown("HotbarSlot3"))
            UseHotBarSlot3();

        if (Input.GetButtonDown("HotbarSlot4"))
            UseHotBarSlot4();

        if (Input.GetButtonDown("HotbarSlot5"))
            UseHotBarSlot5();

        if (Input.GetButtonDown("HotbarSlot6"))
            UseHotBarSlot6();

        if (Input.GetButtonDown("HotbarSlot7"))
            UseHotBarSlot7();

        if (Input.GetButtonDown("HotbarSlot8"))
            UseHotBarSlot8();

        if (Input.GetButtonDown("HotbarSlot9"))
            UseHotBarSlot9();
    }

    private void FixedUpdate()
    {
        if (inputEnabled)
        {
            Walk?.Invoke(Input.GetAxis("Vertical"));

            Rotate?.Invoke(Input.GetAxis("Horizontal"));
        }

        if (Input.GetAxis("Sprint") != 0)
            TriggerSprint();
    }

    //Function: OnPause
    //DESCRIPTION: this function disables input on pause
    //PARAMETERS: None
    //RETURNS: None
    public static void OnPause()
    {
        inputEnabled = false;
    }

    //Function: UnPause
    //DESCRIPTION: this function enables input when game is unpaused
    //PARAMETERS: None
    //RETURNS: None
    public static void UnPause()
    {
        inputEnabled = true;
    }

    //Function: TriggerControllerHotbarSlot1
    //DESCRIPTION: function used to trigger the event for the first slot on controller hotbars
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerControllerHotbarSlot1()
    {
        if(inputEnabled)
            ControllerHotbarSlot1?.Invoke();
    }

    //Function: TriggerControllerHotbarSlot2
    //DESCRIPTION: function used to trigger the second slot event for controllers
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerControllerHotbarSlot2()
    {
        if (inputEnabled)
            ControllerHotbarSlot2?.Invoke();
    }

    //Function: TriggerControllerHotbarSlot3
    //DESCRIPTION: function used to trigger the third slot event for controllers
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerControllerHotbarSlot3()
    {
        if (inputEnabled)
            ControllerHotbarSlot3?.Invoke();
    }

    //Function: TriggerControllerHotbarSlot4
    //DESCRIPTION: function used to trigger the fourth slot event for controllers
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerControllerHotbarSlot4()
    {
        if (inputEnabled)
            ControllerHotbarSlot4?.Invoke();
    }

    //Function: TriggerLeftBumper
    //DESCRIPTION: function used to trigger the left bumper event
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerLeftBumper()
    {
        if (inputEnabled)
            LeftBumper?.Invoke(true);
    }

    //Function: TriggerRightBumper
    //DESCRIPTION: function used to trigger the right bumper event
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerRightBumper()
    {
        if (inputEnabled)
            RightBumper?.Invoke(true);
    }

    //Function: TriggerSprint
    //DESCRIPTION: function used to trigger the sprint event
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerSprint()
    {
        if (inputEnabled)
            Sprint?.Invoke();
    }

    //Function: TriggerJump
    //DESCRIPTION: Calls the event for jumping
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerJump()
    {
        if (inputEnabled)
            Jump?.Invoke();
    }

    //Function: TriggerInteract
    //DESCRIPTION: Calls the event for interacting
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerInteract()
    {
        if (inputEnabled)
            Interact?.Invoke();
    }

    //Function: TriggerAttack
    //DESCRIPTION: Calls the event for attacking
    //PARAMETERS: None
    //RETURNS: None
    public static void TriggerAttack()
    {
        if (inputEnabled)
            Attack?.Invoke();
    }

    //Function: TriggerAbility1
    //DESCRIPTION: Calls the event for the ability in the 1 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void UseHotBarSlot1()
    {
        if (inputEnabled)
            HotbarSlot1?.Invoke();
    }

    //Function: TriggerAbility2
    //DESCRIPTION: Calls the event for the ability in the 2 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void UseHotBarSlot2()
    {
        if (inputEnabled)
            HotbarSlot2?.Invoke();
    }

    //Function: TriggerAbility3
    //DESCRIPTION: Calls the event for the ability in the 3 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void UseHotBarSlot3()
    {
        if (inputEnabled)
            HotbarSlot3?.Invoke();
    }

    //Function: TriggerAbility4
    //DESCRIPTION: Calls the event for the ability in the 4 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void UseHotBarSlot4()
    {
        if (inputEnabled)
            HotbarSlot4?.Invoke();
    }

    //Function: TriggerAbility5
    //DESCRIPTION: Calls the event for the ability in the 5 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void UseHotBarSlot5()
    {
        if (inputEnabled)
            HotbarSlot5?.Invoke();
    }

    //Function: TriggerAbility6
    //DESCRIPTION: Calls the event for the ability in the 6 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void UseHotBarSlot6()
    {
        if (inputEnabled)
            HotbarSlot6?.Invoke();
    }

    //Function: TriggerAbility7
    //DESCRIPTION: Calls the event for the ability in the 7 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void UseHotBarSlot7()
    {
        if (inputEnabled)
            HotbarSlot7?.Invoke();
    }

    //Function: TriggerAbility8
    //DESCRIPTION: Calls the event for the ability in the 8 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void UseHotBarSlot8()
    {
        if (inputEnabled)
            HotbarSlot8?.Invoke();
    }

    //Function: TriggerAbility9
    //DESCRIPTION: Calls the event for the ability in the 9 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void UseHotBarSlot9()
    {
        if (inputEnabled)
            HotbarSlot9?.Invoke();
    }

    //Function: TriggerAbility0
    //DESCRIPTION: Calls the event for the ability in the 0 slot
    //PARAMETERS: None
    //RETURNS: None
    public static void UseHotBarSlot0()
    {
        if (inputEnabled)
            HotbarSlot0?.Invoke();
    }

    //Function: RefocusEventSystem
    //DESCRIPTION: this function is used to refocus the event system
    //PARAMETERS: GameObject focus
    //RETURNS: None
    public static void RefocusEventSystem(GameObject focus)
    {
        EventSystem.current.SetSelectedGameObject(focus.GetComponentInChildren<Button>().gameObject);
    }

}
