//FILE : KillQuest.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : 09/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : KillQuest
//PURPOSE : Giving the quests function the correct information for the current quest
public class KillQuest : QuestGoal
{
    public string EnemyID { get; set; }

    public KillQuest(Quests quest, string enemyID, string description, bool completed, int currentAmount, int requiredAmount, int coins)
    {
        this.Quest = quest;
        this.EnemyID = enemyID;
        this.Description = description;
        this.Completed = completed;
        this.CurrentAmount = currentAmount;
        this.RequiredAmount = requiredAmount;
        this.CoinReward = coins;

    }

    public override void Init()
    {
        base.Init();
        QuestEvents.EndEvent += EnemyDied;
    }

    void EnemyDied(IQuestID enemy)
    {
        if (enemy.ID == this.EnemyID)
        {
            this.CurrentAmount++;
            Evaluate();
        }
    }
}
