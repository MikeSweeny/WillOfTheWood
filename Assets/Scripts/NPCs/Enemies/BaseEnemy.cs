using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : BaseNpc
{
    public EnemyObject objectBrain;
    public int vigilant;
    public float attackRange;

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
        currentHealth = maxHealth;
        player = FindObjectOfType<Player>();
        animController = GetComponent<Animator>();
        nextAttack = Time.time;
        attackSpeed = animController.GetAnimatorTransitionInfo(2).duration;
    }

    private void Update()
    {
        if (state != CurrentState.dead)
        {
            switch (state)
            {
                case CurrentState.waiting:
                    CheckIfActive();
                    ResetAnims();
                    break;

                case CurrentState.moving:
                    RoamingPatterns();
                    FindTarget(attackRange);
                    break;

                case CurrentState.attacking:
                    attackingDestination = new Vector3((player.transform.position.x + 2), player.transform.position.y, (player.transform.position.z + 2));
                    RotateEnemy();
                    CheckIfCanAttack();
                    StopAttacking();
                    break;

                case CurrentState.paused:
                    break;

                default:
                    break;
            }
        }
    }

    private void ResetAnims()
    {
        animController.SetLayerWeight(1, 1);
        animController.SetLayerWeight(1, 0);
        animController.SetLayerWeight(2, 0);
        animController.SetBool("Attacking", false);
        animController.SetBool("Walking", false);
    }

    private void CheckIfActive()
    {
        if(gameObject.activeInHierarchy)
        {
            state = CurrentState.moving;
        }
    }

    private void CheckIfCanAttack()
    {
        if (state == CurrentState.attacking)
        {
            if (Time.time >= nextAttack)
            {
                nextAttack = Time.time + attackSpeed;
                AttackTarget();
            }
            else
            {
                animController.SetBool("Attacking", false);
            }
        }
    }

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

    private void RotateEnemy()
    {
        Vector3 targetDirection = player.transform.position - transform.position;
        singleStep = turnSpeed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }

    private void AttackTarget()
    {
        if ((player.transform.position - transform.position).magnitude <= attackRange)
        {
            animController.SetLayerWeight(2, 1);
            pathingPattern.GetNavMeshAgent().SetDestination(attackingDestination);
            animController.SetBool("Attacking", true);
        }
    }

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

}

