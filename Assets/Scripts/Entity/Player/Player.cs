using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacterBase
{
    public PlayerObject playerBrain;

    private bool canShootTargetRay = false;
    private GameObject target;
    private Vector3 rayFiringPoint;


    private void Awake()
    {
        setStats();
        getStats();
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

        rayFiringPoint = new Vector3(transform.position.x, (transform.position.y + 1f), transform.position.z);
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

    //Function: FindPlayerTarget
    //DESCRIPTION: finds the target in front of the player if there is one
    //PARAMETERS: RaycastHit hit
    //RETURNS: hit.collider.gameObject
    public GameObject FindPlayerTarget()
    {
        RaycastHit hit;

        if (Physics.Raycast(rayFiringPoint, transform.forward, out hit, 8))
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
