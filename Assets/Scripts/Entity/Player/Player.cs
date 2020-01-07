﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : CharacterBase
{
    public PlayerObject playerBrain;

    private bool canShootTargetRay = false;
    private GameObject target;
    private Vector3 midRayFiringPoint;
    private Vector3 bottomRayFiringPoint;
    private float expCap;
    private float currentEXP;
    private int playerCoins;
    private int playerStatPoints;


    private void Awake()
    {
        getStats();
        setStats();
        expCap = 200f;
        currentEXP = 0;
        playerCoins = 0;
    }

    private void Update()
    {
        if (canShootTargetRay == true)
        {
            canShootTargetRay = false;
            FindPlayerTarget();
        }
        else
        {
            canShootTargetRay = true;
        }

        if(currentHealth < 0)
        {
            currentHealth = 0;
            SceneManager.LoadScene("DeathScene");
        }

        midRayFiringPoint = new Vector3(transform.position.x, (transform.position.y + 1), transform.position.z);
        bottomRayFiringPoint = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
    }

    //FUNCTION : setStats()
    //DESCRIPTION : Seting the stats from the StatsSet onto the player
    //PARAMETERS : types and names
    //RETURNS : type and use 
    public void setStats()
    {
        accuracy = playerBrain.accuracy;
        discrete = playerBrain.discrete;
        persuasive = playerBrain.pursuasive;
        quick = playerBrain.quick;
        strong = playerBrain.strong;
        toughness = playerBrain.toughness;
    }

    //FUNCTION : getStats()
    //DESCRIPTION : Getting the Stats from the playerObject
    //PARAMETERS : void
    //RETURNS : void
    public void getStats()
    {
        playerBrain.Initialize();

    }

    //Function: FindPlayerTarget
    //DESCRIPTION: finds the target in front of the player if there is one
    //PARAMETERS: RaycastHit hit
    //RETURNS: hit.collider.gameObject, null
    public GameObject FindPlayerTarget()
    {
        RaycastHit hit;

        if (Physics.Raycast(midRayFiringPoint, transform.forward, out hit, 8) || Physics.Raycast(bottomRayFiringPoint, transform.forward, out hit, 8))
        {
            target = hit.collider.gameObject;
            return target;
        } 
        else
        {
            target = null;
        }
        return target;
    }

    //Function: GetPlayerTarget
    //DESCRIPTION: returns the players target for use in outside functions
    //PARAMETERS: None
    //RETURNS: GameObject target
    public GameObject GetPlayerTarget()
    {
        return target;
    }

    //Function: GetXPPercent
    //DESCRIPTION: function used to get the current percent of xp bar filled
    //PARAMETERS: None
    //RETURNS: float
    public float GetXPPercent()
    {
        return currentEXP / expCap;
    }

    //Function: AddXP
    //DESCRIPTION: this function will be used to add xp to the player
    //PARAMETERS: int amount
    //RETURNS: None
    public void AddXP(int amount)
    {
        if(currentEXP < expCap)
        {
            currentEXP += (float)amount;
        }
        else if(currentEXP >= expCap)
        {
            currentEXP = expCap;
        }
    }

    //Function: GetPlayerCoins
    //DESCRIPTION: function used to get the player coins
    //PARAMETERS: None
    //RETURNS: float playerCoins
    public int GetPlayerCoins()
    {
        return playerCoins;
    }

    //Function: SubtractCoins
    //DESCRIPTION: function used to spend / remove coins
    //PARAMETERS: int amount
    //RETURNS: None
    public void SubtractCoins(int amount)
    {
        playerCoins -= amount;
    }

    //Function: AddCoins
    //DESCRIPTION: function used to add / recieve coins
    //PARAMETERS: int amount
    //RETURNS: None
    public void AddCoins(int amount)
    {
        playerCoins += amount;
    }
    public void LevelUp()
    {
        if(currentEXP == expCap)
        {
            playerStatPoints = 1;
            currentEXP = 0;
        }
    }
    public void UsedStatPoint()
    {
        playerStatPoints -= 1;
    }
    public int GetStatPoints()
    {
        return playerStatPoints;
    }
}
