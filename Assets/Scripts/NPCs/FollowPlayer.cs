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

    public float hangBack;

    public string TargetTag;
    public string CompletionArea;

    private GameObject Target;
    private float distBetweenTarget;
    private Vector3 ToTarget;

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
            if (distBetweenTarget  > hangBack)
            {
                GetTargetPosition();
                pathingPattern.FollowPlayer(Target);
            } 
            
        }
     
    }

    private void GetTargetPosition()
    {
        Target = GameObject.FindGameObjectWithTag(TargetTag);
        ToTarget = Target.transform.position;

        distBetweenTarget = Vector3.Distance(this.transform.position, ToTarget);

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
