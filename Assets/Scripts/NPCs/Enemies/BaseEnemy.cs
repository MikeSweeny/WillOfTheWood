﻿//FILE: BaseEnemy.cs
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
    private bool isDead = false;
    private AudioSource source;

    public StatsObject npcStats;


    private float respawnDelay = 15f;
    private float respawnTimer;

    private Vector3 originalPos;

    protected CurrentState state = CurrentState.waiting;

    private void Awake()
    {
        SetStats();
        CalcToughness();
        CalcPainThreshold();
        SetDefence();
        player = FindObjectOfType<Player>();
        animController = GetComponent<Animator>();
        nextAttack = Time.time;
        attackSpeed = animController.GetAnimatorTransitionInfo(2).duration;
        ID = IDName;
        SetPathingComp();
        source = GetComponent<AudioSource>();
        pathingPattern.ToggleWeaponCollider();
        originalPos = gameObject.transform.position;
    }

    private void Update()
    {
        if (state != CurrentState.dead)
        {
            CheckEnemyHealth();
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
        }
        else if(state == CurrentState.dead)
        {
            isDead = true;
            Invoke("DespawnEnemyCorpse", 1);
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
        pathingPattern.ToggleWeaponCollider();
        if(animController.GetCurrentAnimatorStateInfo(2).normalizedTime > 1)
        {
            animController.SetBool("Attacking", false);
            pathingPattern.ToggleWeaponCollider();
        }
        //if (source)
        //    source.Play();
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

    //Function: CheckEnemyHealth
    //DESCRIPTION: checks to see if the enemy is dead
    //PARAMETERS: None
    //RETURNS: None
    private void CheckEnemyHealth()
    {
        if(currentHealth < 0)
        {
            currentHealth = 0;
            state = CurrentState.dead;
        }
    }

    //Function: DespawnEnemyCorpse
    //DESCRIPTION: function used to despawn enemies
    //PARAMETERS: None
    //RETURNS: None
    private void DespawnEnemyCorpse()
    {
        this.gameObject.SetActive(false);
        if (isDead == true)
        {
            Cleared();
            isDead = false;
            InvokeRepeating("RespawnEnemy", 2, 1);
        }

    }

    //Function: RespawnEnemy
    //DESCRIPTION: this function is used to respawn the enemy
    //PARAMETERS: None
    //RETURNS: None
    private void RespawnEnemy()
    {
        respawnTimer++;
        if (respawnTimer >= respawnDelay)
        {
            respawnTimer = 0;
            currentHealth = maxHealth;
            SetStats();
            SetDefence();
            state = CurrentState.waiting;
            gameObject.SetActive(true);
            CancelInvoke();
            gameObject.transform.position = originalPos;
            print("respawned");
        }
    }

    public void Cleared()
    {
        QuestEvents.ItemCleared(this);
    }

    public void OnDeath()
    {
        if (WaveManager.enemyCount > 0)
        {
            WaveManager.enemyCount--;
        }
    }
    public void SetStats()
    {
        accuracy = npcStats.Accuracy;
        speed = npcStats.Speed;
        strong = npcStats.Strong;
        vigilant = npcStats.Vigilant;
    }


}

