﻿//FILE: PlayerController.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 06/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//NAME: PlayerController
//PURPOSE: This class will be for controlling the player movements and interactions
public class PlayerController : MonoBehaviour
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

    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        InputManager.Walk += Movement;
        InputManager.Rotate += TurnPlayer;
        InputManager.Jump += PlayerJump;
        InputManager.Attack += PlayerAttack;
        InputManager.HotbarSlot1 += ActivateHotbarSlot1;
        InputManager.HotbarSlot2 += ActivateHotbarSlot2;
        InputManager.HotbarSlot3 += ActivateHotbarSlot3;
        InputManager.HotbarSlot4 += ActivateHotbarSlot4;
        InputManager.HotbarSlot5 += ActivateHotbarSlot5;
        InputManager.HotbarSlot6 += ActivateHotbarSlot6;
        InputManager.HotbarSlot7 += ActivateHotbarSlot7;
        InputManager.HotbarSlot8 += ActivateHotbarSlot8;
        InputManager.HotbarSlot9 += ActivateHotbarSlot9;
        InputManager.HotbarSlot0 += ActivateHotbarSlot0;
    }

    private void Update()
    {

        moveDirection.y -= gravity * Time.deltaTime;

        grounded = ((controller.Move(moveDirection * Time.deltaTime)) & CollisionFlags.Below) != 0;

        jumping = grounded ? false : jumping;
    }

    //Function: Movement
    //DESCRIPTION: function for moving the player forward and backward
    //PARAMETERS: float verticalMovement
    //RETURNS: None
    private void Movement(float verticalMovement)
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

        moveDirection *= isWalking ? walkSpeed * speedMultiplier : runSpeed * speedMultiplier;

        moveDirection = transform.TransformDirection(moveDirection);
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

    //Function: PlayerJump
    //DESCRIPTION: function for allowing the player to jump
    //PARAMETERS: None
    //RETURNS: None
    private void PlayerJump()
    {
        if(!jumping)
        {
            jumping = true;
            moveDirection.y = jumpSpeed;
            moveDirection = transform.TransformDirection(moveDirection);
        }
    }

    //Function: PlayerAttack
    //DESCRIPTION:  This function will allow the player to execute their attack and switch to the attack animation
    //PARAMETERS: None
    //RETURNS: None
    private void PlayerAttack()
    {
        print("Attacking");
    }

    //Function: ActivateHotbarSlot1
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 1 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot1()
    {
        print("Used slot 1");
    }

    //Function: ActivateHotbarSlot2
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 2 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot2()
    {
        print("Used slot 2");
    }

    //Function: ActivateHotbarSlot3
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 3 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot3()
    {
        print("Used slot 3");
    }

    //Function: ActivateHotbarSlot4
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 4 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot4()
    {
        print("Used slot 4");
    }

    //Function: ActivateHotbarSlot5
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 5 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot5()
    {
        print("Used slot 5");
    }

    //Function: ActivateHotbarSlot6
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 6 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot6()
    {
        print("Used slot 6");
    }

    //Function: ActivateHotbarSlot7
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 7 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot7()
    {
        print("Used slot 7");
    }

    //Function: ActivateHotbarSlot8
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 8 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot8()
    {
        print("Used slot 8");
    }

    //Function: ActivateHotbarSlot9
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 9 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot9()
    {
        print("Used slot 9");
    }

    //Function: ActivateHotbarSlot0
    //DESCRIPTION: this function is used to activate whichever powerup / item is in slot 0 of the player hotbar
    //PARAMETERS: None
    //RETURNS: None
    private void ActivateHotbarSlot0()
    {
        print("Used slot 0");
    }

}
