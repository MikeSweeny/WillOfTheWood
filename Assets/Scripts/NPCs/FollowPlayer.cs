//FILE: FollowPlayer.cs
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

    public string TargetTag;
    public string CompletionArea;

    private GameObject Target;
    private Transform ToTarget;

    private void Awake()
    {
        StopFollowing = false;
        BeginFollowing = false;
        

        pathingPattern = GetComponent<NpcPathing>();
        SetPathingComp();
    }

    private void FixedUpdate()
    {            

        if (BeginFollowing)
        {
            GetTargetPosition();
            pathingPattern.FollowPlayer(Target);
        }
        else if (StopFollowing)
        {
            GetTargetPosition();
            pathingPattern.FollowPlayer(Target);
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
            //StopFollowing = true;
            //Target = GameObject.Find("SarekHandin");
            //ToTarget = Target.transform;
        }
    }
}
