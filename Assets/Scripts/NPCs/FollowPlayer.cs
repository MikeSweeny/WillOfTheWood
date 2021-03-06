﻿//FILE: FollowPlayer.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: Timothy Olenio
//FIRST VERSION: 08/01/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//NAME: FollowPlayer
//PURPOSE: this script moves NPCs so that they follow the player 
public class FollowPlayer : BaseNpc
{

    private bool StopFollowing;
    public bool BeginFollowing;
    protected bool CanWalk;
    protected Animator characterAnim;
   
    public string TargetTag;
    public string CompletionArea;

    private GameObject Target;
    private Transform ToTarget;



    private void Awake()
    {
        StopFollowing = false;
        BeginFollowing = false;
        characterAnim = GetComponent<Animator>();


        pathingPattern = GetComponent<NpcPathing>();
        SetPathingComp();
        
    }

    private void Update()
    {

    }
    private void FixedUpdate()
    {
        
        if (BeginFollowing)
        {
            GetTargetPosition();
            pathingPattern.FollowPlayer(Target);
            SpeedCheck();
            //characterAnim.Play("Walking");

        }
        else if (StopFollowing)
        {
            GetTargetPosition();
            //pathingPattern.FollowPlayer(Target);
            SpeedCheck();
        }
    }

    private void SpeedCheck()
    {

        if (Vector3.Distance(transform.position, Target.transform.position) <= 1.5)
        {
            CanWalk = false;
            characterAnim.SetBool("CanWalk", false);
            BeginFollowing = false;
            StopFollowing = true;

        }
        else
        {
            CanWalk = true;
            characterAnim.SetBool("CanWalk", true);
            BeginFollowing = true;
            StopFollowing = false;
        }


    }
    private void GetTargetPosition()
    {
        Target = GameObject.FindGameObjectWithTag(TargetTag);
        //ToTarget = Target.transform;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == CompletionArea)
        {
            BeginFollowing = false;
            StopFollowing = false;
            CanWalk = false;
            characterAnim.SetBool("CanWalk", false);
            gameObject.GetComponent<ConversationNpc>().NotMoveable = false;
            //StopFollowing = true;
            //Target = GameObject.Find("SarekHandin");
            //ToTarget = Target.transform;
        }
    }
}
