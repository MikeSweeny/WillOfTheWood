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

    protected bool CanWalk;
    protected Animator characterAnim;
   
    public string TargetTag;
    public string CompletionArea;

    private GameObject Target;
    private float distBetweenTarget;
    private Vector3 ToTarget;



    private void Awake()
    {
        StopFollowing = false;
        BeginFollowing = false;
        characterAnim = GetComponent<Animator>();


        pathingPattern = GetComponent<NpcPathing>();
        SetPathingComp();
        
    }

    private void FixedUpdate()
    {
        
        if (BeginFollowing)
        {
                GetTargetPosition();
                pathingPattern.FollowPlayer(Target);
                SpeedCheck();

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

        //if (Target.transform.position == gameObject.transform.position)
        if (Vector3.Distance(transform.position, Target.transform.position) <= 1.25)
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
        //ToTarget = Target.transform.position;

        //distBetweenTarget = Vector3.Distance(this.transform.position, ToTarget);

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
            //Target = GameObject.Find("SarekHandin");
            //ToTarget = Target.transform;
        }
    }
}
