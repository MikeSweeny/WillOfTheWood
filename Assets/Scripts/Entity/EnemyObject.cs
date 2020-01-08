
////File Header:
////FILE : EnemyObject.cs
//////PROJECT : WillOfTheWood
////PROGRAMMER : Jeff
////FIRST VERSION : 06/12/2019

////Class Header:
////NAME : EnemyObject : EntityObject
////PURPOSE : To setup and initialize base Game Entities like the Player, Enemies and NPCs
//using UnityEngine;
//[CreateAssetMenu(menuName = "Entity/Enemy", fileName = "Entities")]
//public class EnemyObject : EntityObject
//{
//    public StatsObject eStats;
//    public GameObject transform;
//    //public AbilitySet pAbilityes;
//    public int accuracy;
//    public int quick;
//    public int strong;
//    public int vigilant;
//    [Tooltip("Toughness is the Entities Health (Toughness = Strong (though never below 10)")]
//    public int toughness;
//    [Tooltip(" Defense = [Quick –Armor’s Impeding value]")]
//    public int defence;
//    [Tooltip(" Pain Threshold = Strong/2 (rounded up)")]
//    public int painThreshold;

//    //FUNCTION : Initialize()
//    //DESCRIPTION : Setting the Stats from the ScriptableObject (StatsSet) to the Enttiy that needs it
//    //PARAMETERS : Void
//    //RETURNS : void

//    public void Initialize()
//    {
//        accuracy = eStats.Accuracy;
//        quick = eStats.Speed;
//        strong = eStats.Strong;
//        vigilant = eStats.Vigilant;
//        CalcToughness();
//        CalcPainThreshold()
//    }


//    // on death:
//    // check if WaveManager.enemyCount > 0 and if so decrement

//    //Function for Spawning at location
//}
