//FILE: PlayerController.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 06/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//NAME: PlayerController
//PURPOSE: This class will be for controlling the player movements and interactions
public class PlayerController : BaseController
{
    public bool walkByDefault = true;
    public float gravity = 20.0f;

    public float jumpSpeed = 75.0f;
    public float runSpeed = 10.0f;
    public float walkSpeed = 4.0f;
    public float turnSpeed = 150.0f;
    public float moveBackwardsMultiplier = 0.75f;

    private float speedMultiplier = 0.0f;
    private bool grounded = false;
    private Vector3 moveDirection = Vector3.zero;
    private bool isWalking = false;
    private bool jumping = false;
    private bool isAttacking = false;
    private Vector3 midRayFiringPoint;
    private Vector3 bottomRayFiringPoint;

    private Animator animController;
    private CharacterController controller;
    private AudioSource source;
    private Player player;

    private void Start()
    {
        animController = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        source = GetComponent<AudioSource>();
        InputManager.Walk += Movement;
        InputManager.Rotate += TurnPlayer;
        InputManager.Jump += PlayerJump;
        InputManager.Attack += Attack;
        InputManager.Interact += PlayerInteract;
        InputManager.Sprint += PlayerSprint;
        InputManager.HotbarSlot1 += ActivateHotbarSlot1;
        InputManager.HotbarSlot2 += ActivateHotbarSlot2;
        InputManager.HotbarSlot3 += ActivateHotbarSlot3;
        InputManager.HotbarSlot4 += ActivateHotbarSlot4;
        InputManager.HotbarSlot5 += ActivateHotbarSlot5;
        InputManager.HotbarSlot6 += ActivateHotbarSlot6;
        InputManager.HotbarSlot7 += ActivateHotbarSlot7;
        InputManager.HotbarSlot8 += ActivateHotbarSlot8;
        InputManager.LeftBumper += LeftBumperPressed;
        InputManager.RightBumper += RightBumperPressed;
        if(weaponCollider && weaponCollider.enabled == true)
            ToggleWeaponCollider();
    }

    private void Update()
    {

        moveDirection.y -= gravity * Time.deltaTime;

        grounded = ((controller.Move(moveDirection * Time.deltaTime)) & CollisionFlags.Below) != 0;

        jumping = grounded ? false : jumping;
        isAttacking = false;

        ResetAnims();

        if (moveDirection.z == 0)
        {
            animController.SetFloat("Speed", moveDirection.z);
        }

        midRayFiringPoint = new Vector3(transform.position.x, (transform.position.y + 1), transform.position.z);
        bottomRayFiringPoint = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
        
    }

    //Function: Movement
    //DESCRIPTION: function for moving the player forward and backward
    //PARAMETERS: float verticalMovement
    //RETURNS: None
    public override void Movement(float verticalMovement)
    {
        isWalking = walkByDefault;
        if (Input.GetMouseButton(1))
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, verticalMovement);
        }
        else
        {
            moveDirection = new Vector3(0, 0, verticalMovement);
        }

        if (verticalMovement < 0)
        {
            speedMultiplier = moveBackwardsMultiplier;
        }
        else
        {
            speedMultiplier = 1;
        }

       if (moveDirection.z > 0)
        {
            animController.SetFloat("Speed", moveDirection.z);
        }

        moveDirection *= walkSpeed * speedMultiplier;
        moveDirection = transform.TransformDirection(moveDirection);
    }

    //Function: PlayerSprint
    //DESCRIPTION: this function is used to set the player to be able to run
    //PARAMETERS: None
    //RETURNS: None
    private void PlayerSprint()
    {
        isWalking = !walkByDefault;
        moveDirection *= runSpeed * speedMultiplier;
    }

    //Function: PlayerInteract
    //DESCRIPTION: This function is the players interact function
    //PARAMETERS: RaycastHit hit
    //RETURNS: None
    private void PlayerInteract()
    {
        RaycastHit hit;

        if (Physics.Raycast(midRayFiringPoint, transform.forward, out hit, 6) || Physics.Raycast(bottomRayFiringPoint, transform.forward, out hit, 6))
        {
            Debug.DrawRay(bottomRayFiringPoint, transform.forward * 5, Color.red, 5.0f);
            //add any other cases for the player to interact with objects with specific tags
            switch (hit.collider.gameObject.tag)
            {
                case "NPC":
                    if (hit.collider.gameObject.GetComponent<BaseInteractableNpc>())
                    {
                        hit.collider.gameObject.GetComponent<BaseInteractableNpc>().OnInteract();
                    }
                    break;
                    //put code here for the doors interactions
                case "Door":
                    break;
                    //put code here for the items interaction ie. adding it to the inventory
                case "Item":
                    if(hit.collider.gameObject.GetComponent<CollectableItems>())
                    {
                        hit.collider.gameObject.GetComponent<CollectableItems>().OnInteract();
                    }
                    break;

                default:
                    break;
            }
        }
    }

    //Function: TurnPlayer
    //DESCRIPTION: function for rotating the player based off mouse inputs
    //PARAMETERS: float horizontalRotation
    //RETURNS: None
    private void TurnPlayer(float horizontalRotation)
    {
        if (Input.GetMouseButton(1))
        {
            transform.rotation = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0);
        }
        else
        {
            transform.Rotate(0, horizontalRotation * turnSpeed * Time.deltaTime, 0);
        }
    }

    //Function: LeftBumperPressed 
    //DESCRIPTION: function used to enable hotbar for controllers
    //PARAMETERS: bool pressed
    //RETURNS: None
    private void LeftBumperPressed(bool pressed)
    {
        InputManager.ControllerHotbarSlot1 -= ActivateRightHotbarSlot1;
        InputManager.ControllerHotbarSlot2 -= ActivateRightHotbarSlot2;
        InputManager.ControllerHotbarSlot3 -= ActivateRightHotbarSlot3;
        InputManager.ControllerHotbarSlot4 -= ActivateRightHotbarSlot4;

        if (pressed)
        {
            InputManager.ControllerHotbarSlot1 += ActivateLeftHotbarSlot1;
            InputManager.ControllerHotbarSlot2 += ActivateLeftHotbarSlot2;
            InputManager.ControllerHotbarSlot3 += ActivateLeftHotbarSlot3;
            InputManager.ControllerHotbarSlot4 += ActivateLeftHotbarSlot4;
        }
    }

    private void RightBumperPressed(bool pressed)
    {
        InputManager.ControllerHotbarSlot1 -= ActivateLeftHotbarSlot1;
        InputManager.ControllerHotbarSlot2 -= ActivateLeftHotbarSlot2;
        InputManager.ControllerHotbarSlot3 -= ActivateLeftHotbarSlot3;
        InputManager.ControllerHotbarSlot4 -= ActivateLeftHotbarSlot4;

        if (pressed)
        {
            InputManager.ControllerHotbarSlot1 += ActivateRightHotbarSlot1;
            InputManager.ControllerHotbarSlot2 += ActivateRightHotbarSlot2;
            InputManager.ControllerHotbarSlot3 += ActivateRightHotbarSlot3;
            InputManager.ControllerHotbarSlot4 += ActivateRightHotbarSlot4;
        }
    }

    //Function: PlayerJump
    //DESCRIPTION: function for allowing the player to jump
    //PARAMETERS: None
    //RETURNS: None
    private void PlayerJump()
    {
        if(!jumping)
        {
            animController.SetBool("Jumping", true);
            jumping = true;
            moveDirection.y += jumpSpeed;
            controller.Move(moveDirection * Time.deltaTime);
            moveDirection.y -= gravity * Time.deltaTime;
        }
    }

    //Function: PlayerAttack
    //DESCRIPTION:  This function will allow the player to execute their attack and switch to the attack animation
    //PARAMETERS: None
    //RETURNS: None
    public override void Attack()
    {
        if(isAttacking == false)
        {
            if(weaponCollider.enabled == false)
            {
                ToggleWeaponCollider();
            }
            animController.SetBool("Attacking", true);
            if (source)
                source.Play();
            isAttacking = true;
        }
    }

    //Function: ResetAnims
    //DESCRIPTION: this function will be used to reset the conditions for the bools in the animator for the player
    //PARAMETERS: None
    //RETURNS: None
    private void ResetAnims()
    {
        if (isAttacking == false && animController.GetCurrentAnimatorStateInfo(0).IsName("PlayerAttack") && animController.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            animController.SetBool("Attacking", false);
            if(weaponCollider.enabled)
                ToggleWeaponCollider();
        }

        if (grounded && (animController.GetCurrentAnimatorStateInfo(0).IsName("Jumping") && animController.GetCurrentAnimatorStateInfo(0).normalizedTime > 1))
        {
            animController.SetBool("Jumping", false);
        }
    }

    //Function: ActivateHotbarSlot1
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 1 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot1()
    {
        GetComponent<Player>().GetHotbar()[0].AbilityAct();
    } 

    //Function: ActivateHotbarSlot2
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 2 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot2()
    {
        print("Used slot 2");
        GetComponent<Player>().GetHotbar()[1].AbilityAct();
    }

    //Function: ActivateHotbarSlot3
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 3 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot3()
    {
        print("Used slot 3");
        GetComponentInParent<Player>().GetHotbar()[2].AbilityAct();
    }

    //Function: ActivateHotbarSlot4
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 4 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot4()
    {
        print("Used slot 4");
        GetComponent<Player>().GetHotbar()[3].AbilityAct();
    }

    //Function: ActivateHotbarSlot5
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 5 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot5()
    {
        print("Used slot 5");
        GetComponent<Player>().GetHotbar()[4].AbilityAct();
    }

    //Function: ActivateHotbarSlot6
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 6 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot6()
    {
        print("Used slot 6");
        GetComponent<Player>().GetHotbar()[5].AbilityAct();
    }

    //Function: ActivateHotbarSlot7
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 7 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot7()
    {
        print("Used slot 7");
        GetComponent<Player>().GetHotbar()[6].AbilityAct();
    }

    //Function: ActivateHotbarSlot8
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 8 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot8()
    {
        print("Used slot 8");
        GetComponent<Player>().GetHotbar()[7].AbilityAct();
    }

    //Function: ActivateLeftHotbarSlot1
    //DESCRIPTION: function used to activate the first left slot for controller
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateLeftHotbarSlot1()
    {
        print("used left first slot");
        GetComponent<Player>().GetHotbar()[0].AbilityAct();
    }

    //Function: ActivateLeftHotbarSlot2
    //DESCRIPTION: function used to activate the second left slot for controller
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateLeftHotbarSlot2()
    {
        print("used left second slot");
        GetComponent<Player>().GetHotbar()[1].AbilityAct();
    }

    //Function: ActivateLeftHotbarSlot3
    //DESCRIPTION: function used to activate the third left slot for controller
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateLeftHotbarSlot3()
    {
        print("used left third slot");
        GetComponent<Player>().GetHotbar()[2].AbilityAct();
    }

    //Function: ActivateLeftHotbarSlot4
    //DESCRIPTION: function used to activate the fourth left slot for controller
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateLeftHotbarSlot4()
    {
        print("used left fourth slot");
        GetComponent<Player>().GetHotbar()[3].AbilityAct();
    }

    //Function: ActivateRightHotbarSlot1
    //DESCRIPTION: function used to activate the first right slot for controller
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateRightHotbarSlot1()
    {
        print("used Right first slot");
        GetComponent<Player>().GetHotbar()[4].AbilityAct();
    }

    //Function: ActivateRightHotbarSlot2
    //DESCRIPTION: function used to activate the second right slot for controller
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateRightHotbarSlot2()
    {
        print("used Right second slot");
        GetComponent<Player>().GetHotbar()[5].AbilityAct();
    }

    //Function: ActivateRightHotbarSlot3
    //DESCRIPTION: function used to activate the third right slot for controller
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateRightHotbarSlot3()
    {
        print("used Right third slot");
        GetComponent<Player>().GetHotbar()[6].AbilityAct();
    }

    //Function: ActivateRightHotbarSlot4
    //DESCRIPTION: function used to activate the fourth right slot for controller
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateRightHotbarSlot4()
    {
        print("used Right fourth slot");
        GetComponent<Player>().GetHotbar()[7].AbilityAct();
    }
}
