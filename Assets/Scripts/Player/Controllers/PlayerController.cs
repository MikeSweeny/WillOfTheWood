//FILE: PlayerController.cs
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
    public PlayerObject playerBrain;            // Added 07/12/2019 - JO.    The Players "Brain" Holds all the stats and stuff that makes the player a Unique
    public bool walkByDefault = true;
    public float gravity = 20.0f;

    public float jumpSpeed = 8.0f;
    public float runSpeed = 10.0f;
    public float walkSpeed = 4.0f;
    public float turnSpeed = 150.0f;
    public float moveBackwardsMultiplier = 0.75f;

    float speedMultiplier = 0.0f;
    bool grounded = false;
    Vector3 moveDirection = Vector3.zero;
    bool isWalking = false;
    bool jumping = false;

    CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        InputManager.Walk += Movement;
        InputManager.Rotate += TurnPlayer;
        InputManager.Jump += PlayerJump;
    }

    private void Update()
    {
        grounded = ((controller.Move(moveDirection * Time.deltaTime)) & CollisionFlags.Below) != 0;
        moveDirection.y -= gravity * Time.deltaTime;
    }

    //Function: Movement
    //DESCRIPTION: function for moving the player forward and backward
    //PARAMETERS: verticalMovement
    //RETURNS: None
    void Movement(float verticalMovement)
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
    //PARAMETERS: horizontalRotation
    //RETURNS: None
    void TurnPlayer(float horizontalRotation)
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
    void PlayerJump()
    {
        jumping = grounded ? false : jumping;

        if(!jumping)
        {
            jumping = true;
            moveDirection.y = jumpSpeed;
        }
    }

}
