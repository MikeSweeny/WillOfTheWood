//FILE : TurnInQuest.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : DD/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnInQuest : QuestGoal
{
    public string EnemyID { get; set; }
    

    public TurnInQuest(Quests quest, string enemyID, string description, bool completed, int currentAmount, int requiredAmount, int coins, string NPCHandIn)
    {
        this.Quest = quest;
        this.EnemyID = enemyID;
        this.Description = description;
        this.Completed = completed;
        this.CurrentAmount = currentAmount;
        this.RequiredAmount = requiredAmount;
        this.CoinReward = coins;
        this.NPCHandIn = NPCHandIn;
    }

    public override void Init()
    {
        base.Init();
        QuestEvents.EndEvent += ItemCollected;
    }

    void ItemCollected(IQuestID items)
    {
        if (items.ID == this.EnemyID)
        {
            this.CurrentAmount++;
            Evaluate();
        }
    }
}
