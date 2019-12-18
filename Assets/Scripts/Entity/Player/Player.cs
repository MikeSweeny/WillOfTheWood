using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int accuracy;
    public int discrete;
    public int persuasive;
    public int quick;
    public int strong;
    public int toughness;
    public float maxHealth = 100f;
    private float currentHealth;
    [Tooltip(" Defense = [Quick –Armor’s Impeding value]")]
    public int defence;
    [Tooltip(" Pain Threshold = Strong/2 (rounded up)")]
    public int painThreshold;


    public PlayerObject playerBrain;

    private bool canShootTargetRay = false;
    private GameObject target;
    private void Awake()
    {
        setStats();
        getStats();
        currentHealth = maxHealth;
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
    }

    private void FixedUpdate()
    {
        CalcToughness();
        CalcPainThreshold();
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
        playerBrain.Initialize();
        //Debug.Log(""+ accuracy +""+ cunning + "" + discrete + "" + persuasive + "" + quick + "" + strong + "" + vigilant);
    }
    //FUNCTION : getStats()
    //DESCRIPTION : Getting the Stats from the playerObject
    //PARAMETERS : void
    //RETURNS : void
    public void getStats()
    {
        playerBrain.Initialize();
        //Debug.Log("" + accuracy + "" + cunning + "" + discrete + "" + persuasive + "" + quick + "" + strong + "" + vigilant);

    }
    //FUNCTION :  CalcToughness()
    //DESCRIPTION : Calcualting the Toughness of the Entity
    //PARAMETERS : void
    //RETURNS : void

    public void CalcToughness()
    {
        if (toughness <= 9)
        {
            toughness = 10;
        }
        if (strong >= 10)
        {
            toughness = strong;
        }
    }
    //FUNCTION : CalcPainThreshold()
    //DESCRIPTION : Calculating the Pain Threshold of the Entity
    //PARAMETERS : void
    //RETURNS : void

    public void CalcPainThreshold()
    {
        painThreshold = strong / 2;
    }

    //Function: FindPlayerTarget
    //DESCRIPTION: finds the target in front of the player if there is one
    //PARAMETERS: RaycastHit hit
    //RETURNS: hit.collider.gameObject
    public GameObject FindPlayerTarget()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 8))
        {
            target = hit.collider.gameObject;
            return target;
        }
        return null;
    }

    //Function: GetPlayerTarget
    //DESCRIPTION: returns the players target for use in outside functions
    //PARAMETERS: None
    //RETURNS: GameObject target
    public GameObject GetPlayerTarget()
    {
        return target;
    }
}
