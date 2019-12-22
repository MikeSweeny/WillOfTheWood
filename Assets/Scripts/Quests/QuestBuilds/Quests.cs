//FILE : Quests.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : 06/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;



//NAME : Quest
//PURPOSE : the Parent to the different types of quests. 

//[CreateAssetMenu(fileName = "New Quest")]
public class Quests : ScriptableObject
{
    //Items not to be touched. 
    public HDialogueInterface QUIM;
    //public Player player;

    public List<QuestGoal> Goals = new List<QuestGoal>();
    public bool currentQuest { get; set; }
    public bool Completed { get; set; }
    public bool isActive { get; set; }
    public int CurrentAmount { get; set; }
    public bool NPCKill { get; set; }
    protected GameObject NPCtoKill;
    protected GameObject NPCHandIn;
    
    public bool SecondNPC { get; set; }

    //Changeable in script able list
    public string QuestName;
    public string Prereq1;
    public string Prereq2;
    public string Description;
    public string NPCID;
    public string TurnInNPCName;
    
    public int RequiredAmount;
    public int ExperenceReward;
    public int CoinReward;
    public int UnitReward;
    //public variable for item reward needed;

    //Descriptions of text
    [TextArea(3, 10)]
    public string QuestObjectives;
    [TextArea(3,10)]
    public string StartQuestText;
    [TextArea(3, 10)]
    public string TrackingQuestText;
    [TextArea(3, 10)]
    public string InprogressQuestText;
    [TextArea(3, 10)]
    public string CompletedQuestText;

    public string SecondInprogressText;


    public virtual void Load() { }

    //FUNCTION : Anything Text
    //DESCRIPTION : Allowing the quests to pass text into the UI
    //PARAMETERS : 
    //RETURNS : 
    public virtual void TrackingQuest() { }
    public virtual void StartText() { }
    public virtual void InprogressText() { }
    public virtual void CompletedText() { }


    void OnEnable()
    {
        //QUIM = FindObjectOfType<QuestUIManager>();
        //player = FindObjectOfType<Player>();
    }


    //FUNCTION : GiveReward
    //DESCRIPTION : gives the player the reward for the quest
    //PARAMETERS : 
    //RETURNS : 
    public virtual void GiveReward()
    {
        //player = FindObjectOfType<player>();
        //if (player)
        //    player.SetCoin(CoinReward);

        Debug.Log("Quest Reward Given.");
    }



}
