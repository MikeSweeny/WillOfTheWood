using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int accuracy;
    public int cunning;
    public int discrete;
    public int persuasive;
    public int quick;
    public int strong;
    public int vigilant;
    [Tooltip("Toughness is the Entities Health (Toughness = Strong (though never below 10)")]
    public int toughness;
    [Tooltip(" Defense = [Quick –Armor’s Impeding value]")]
    public int defence;
    [Tooltip(" Pain Threshold = Strong/2 (rounded up)")]
    public int painThreshold;


    public PlayerObject playerBrain;

    private void Awake()
    {
        setStats();
        getStats();

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
        cunning = playerBrain.cunning;
        discrete = playerBrain.discrete;
        persuasive = playerBrain.pursuasive;
        quick = playerBrain.quick;
        strong = playerBrain.strong;
        vigilant = playerBrain.vigilant;
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
}
