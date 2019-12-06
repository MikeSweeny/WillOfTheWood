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

    public bool walkByDefault = true;
    public float gravity = 20.0f;

    public float jumpSpeed = 8.0f;
    public float runSpeed = 10.0f;
    public float walkSpeed = 4.0f;
    public float turnSpeed = 250.0f;
    public float moveBackwardsMultiplyer = 0.75f;

    float speedMultiplyer = 0.0f;
    bool grounded = false;
    Vector3 moveDirection = Vector3.zero;
    bool isWalking = false;
    bool jumping = false;

    CharacterController controller;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        InputManager.Walk += Movement;
        InputManager.Rotate += TurnPlayer;
        InputManager.Jump += PlayerJump;
    }

    void Movement(float verticalMovement)
    {
        if (Input.GetMouseButton(1))
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, verticalMovement);
        }
        else
        {
            moveDirection = new Vector3(0, 0, verticalMovement);
        }

        moveDirection *= isWalking ? walkSpeed * speedMultiplyer : runSpeed * speedMultiplyer;

        moveDirection = transform.TransformDirection(moveDirection);
    }

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

    void PlayerJump()
    {
        jumping = true;
        moveDirection.y = jumpSpeed;

        moveDirection.y -= gravity * Time.deltaTime;

        grounded = ((controller.Move(moveDirection * Time.deltaTime)) & CollisionFlags.Below) != 0;

        jumping = grounded ? false : jumping;
    }

}
