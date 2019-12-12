
//File Header:
//FILE : EnemyObject.cs
////PROJECT : WillOfTheWood
//PROGRAMMER : Jeff
//FIRST VERSION : 06/12/2019

//Class Header:
//NAME : EnemyObject : EntityObject
//PURPOSE : To setup and initialize base Game Entities like the Player, Enemies and NPCs
using UnityEngine;
[CreateAssetMenu(menuName = "Entity/Enemy", fileName = "Entities")]
public class EnemyObject : EntityObject
{
    public StatSet eStats;
    //public AbilitySet pAbilityes;
    //public AIControler? (Dunno name) AIBrain;
    public int gold;
    public int accuracy;
    public int quick;
    public int strong;
    public int vigilance;
    [Tooltip("Toughness is the Entities Health (Toughness = Strong (though never below 10)")]
    public int toughness;
    [Tooltip(" Defense = [Quick –Armor’s Impeding value]")]
    public int defence;
    [Tooltip(" Pain Threshold = Strong/2 (rounded up)")]
    public int painThreshold;

    //FUNCTION : Initialize()
    //DESCRIPTION : Setting the Stats from the ScriptableObject (StatsSet) to the Enttiy that needs it
    //PARAMETERS : Void
    //RETURNS : void

    public void Initialize()
    {
        accuracy = eStats.accuracy;
        quick = eStats.quick;
        strong = eStats.strong;
        vigilance = eStats.vigilance;
        CalcToughness();
        CalcPainThreshold();
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
    //FUNCTION : OnDeath()
    //DESCRIPTION : what happens then the entitiy dies
    //PARAMETERS : void
    //RETURNS : void 
    public void OnDeath()
    {
        if(WaveManager.enemyCount > 0)
        {
            WaveManager.enemyCount--;
        }
    }


    // on death:
    // check if WaveManager.enemyCount > 0 and if so decrement

    //Function for Spawning at location
}
