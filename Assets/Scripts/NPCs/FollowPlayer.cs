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
    private NavMeshAgent agent;

    private bool StopFollowing;
    private bool BeginFollowing;

    public string TargetTag;

    private GameObject Target;
    private Transform ToTarget;

    private void Awake()
    {
        StopFollowing = false;
        BeginFollowing = false;
        Target = GameObject.FindGameObjectWithTag(TargetTag);
        ToTarget = Target.transform;
        agent = GetComponent<NavMeshAgent>();

        //pathingPattern = GetComponent<NpcPathing>();
        //SetPathingComp();
    }

    private void FixedUpdate()
    {            
        BeginFollowing = true;

        if (BeginFollowing)
        {
            agent.SetDestination(ToTarget.position);
            //pathingPattern.FollowPlayer(Target);
        }
    }
}
