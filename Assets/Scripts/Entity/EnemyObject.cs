
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
    public SecondaryStatsSet eSecondaryStats;
    //public AbilitySet pAbilityes;
    //public PlayerController player;
    //public Inventory inventory;
    public int gold;
    public int accuracy;
    public int cunning;
    public int discrete;
    public int pursuasive;
    public int quick;
    public int strong;
    public int vigilant;
    public int armour;
    public int toughness;
    public int defence;
    public int painThreshold;

    public void Initialize()
    {
        accuracy = eStats.accuracy;
        cunning = eStats.cunning;
        discrete = eStats.discrete;
        pursuasive = eStats.pursuasive;
        quick = eStats.quick;
        strong = eStats.strong;
        vigilant = eStats.vigilant;
        armour = eSecondaryStats.armour;
        toughness = eSecondaryStats.toughness;
        defence = eSecondaryStats.defence;
        painThreshold = eSecondaryStats.painThreshold;

    }


    // on death:
    // check if WaveManager.enemyCount > 0 and if so decrement

    //Function for Spawning at location
}
