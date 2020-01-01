//FILE: BaseEnemy.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 20/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME: BaseEnemy
//PURPOSE: this class serves as the parent for all enemies
public class BaseEnemy : BaseNpc, IQuestID
{
    public EnemyObject objectBrain;
    public int vigilant;
    public float attackRange;
    public string ID { get; set; }

    public string IDName;
    private Player player;
    private float turnSpeed = 1.0f;
    private float singleStep;
    private Animator animController;
    private Vector3 attackingDestination;
    private float nextAttack;
    private float attackSpeed;

    protected CurrentState state = CurrentState.waiting;

    private void Awake()
    {
        getStats();
        setStats();
        player = FindObjectOfType<Player>();
        animController = GetComponent<Animator>();
        nextAttack = Time.time;
        attackSpeed = animController.GetAnimatorTransitionInfo(2).duration;
        ID = IDName;
        SetPathingComp();
    }

    private void Update()
    {
        if (state != CurrentState.dead)
        {
            switch (state)
            {
                case CurrentState.waiting:
                    CheckIfActive();
                    break;

                case CurrentState.moving:
                    ResetAnims();
                    RoamingPatterns();
                    FindTarget(attackRange);
                    break;

                case CurrentState.attacking:
                    attackingDestination = new Vector3((player.transform.position.x), player.transform.position.y, (player.transform.position.z + 2));
                    RotateEnemy();
                    CheckIfCanAttack();
                    StopAttacking();
                    break;

                case CurrentState.paused:
                    break;

                default:
                    break;
            }
            print(currentHealth);
        }
    }

    //Function: ResetAnims
    //DESCRIPTION: function used to reset the animations so the enemy is walking
    //PARAMETERS: None
    //RETURNS: None
    private void ResetAnims()
    {
        animController.SetLayerWeight(1, 1);
        animController.SetLayerWeight(2, 0);
        animController.SetBool("Attacking", false);
        animController.SetBool("Walking", true);
    }

    //Function: CheckIfActive
    //DESCRIPTION: this function simply checks if the object is active then sets the state to moving
    //PARAMETERS: None
    //RETURNS: None
    private void CheckIfActive()
    {
        if(gameObject.activeInHierarchy)
        {
            state = CurrentState.moving;
        }
    }

    //Function: CheckIfCanAttack
    //DESCRIPTION: this function checks to see if the enemy can attack or not
    //PARAMETERS: None
    //RETURNS: None
    private void CheckIfCanAttack()
    {
        if (state == CurrentState.attacking)
        {
            if (Time.time > nextAttack)
            {
                nextAttack = Time.time + attackSpeed;
                AttackTarget();
            }
        }
    }

    //Function: FindTarget
    //DESCRIPTION: this function is used to find the player, if they are found within range then it sets the state to attacking and checks to see if it can attack
    //PARAMETERS: float range
    //RETURNS: None
    private void FindTarget(float range)
    {
        if (player)
        {
            if (Vector2.Distance(transform.position, player.transform.position) <= range)
            {
                state = CurrentState.attacking;
                CheckIfCanAttack();
            }
        }
    }

    //Function: RotateEnemy
    //DESCRIPTION: this function rotates the enemy to face the player
    //PARAMETERS: Vector3 targetDirection, Vector3 newDirection
    //RETURNS: None
    private void RotateEnemy()
    {
        Vector3 targetDirection = player.transform.position - transform.position;
        singleStep = turnSpeed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }

    //Function: AttackTarget
    //DESCRIPTION: this function is used to attack the target, moving to a point close to them
    //PARAMETERS: None
    //RETURNS: None
    private void AttackTarget()
    {
        animController.SetLayerWeight(2, 1);
        pathingPattern.GetNavMeshAgent().SetDestination(attackingDestination);
        animController.SetBool("Attacking", true);
        if(animController.GetCurrentAnimatorStateInfo(2).normalizedTime > 1)
        {
            animController.SetBool("Attacking", false);
        }
    }

    //Function: StopAttacking
    //DESCRIPTION: this function is used to see if the player is out of range before setting the state back to moving
    //PARAMETERS: None
    //RETURNS: None
    private void StopAttacking()
    {
        if (Vector2.Distance(transform.position, player.transform.position) > attackRange)
        {
            state = CurrentState.moving;
        }
    }

    public void setStats()
    {
        accuracy = objectBrain.accuracy;
        quick = objectBrain.quick;
        strong = objectBrain.strong;
        toughness = objectBrain.toughness;
        vigilant = objectBrain.vigilant;
    }

    //FUNCTION : getStats()
    //DESCRIPTION : Getting the Stats from the objectBrain
    //PARAMETERS : void
    //RETURNS : void
    public void getStats()
    {
        objectBrain.Initialize();
    }

    public void Cleared()
    {
        QuestEvents.ItemCleared(this);
    }

}

