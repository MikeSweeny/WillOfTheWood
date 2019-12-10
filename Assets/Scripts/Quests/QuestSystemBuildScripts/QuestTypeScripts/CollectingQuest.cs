//FILE : CollectingQuest.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : 09/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : CollectingQuest
//PURPOSE : Giving the quests function the correct information for the current quest
public class CollectingQuest : QuestGoal
{
    public string ItemID { get; set; }

    public CollectingQuest(Quests quest, string itemID, string description, bool completed, int currentAmount, int requiredAmount, int coins)
    {
        this.Quest = quest;
        this.ItemID = itemID;
        this.Description = description;
        this.Completed = completed;
        this.CurrentAmount = currentAmount;
        this.RequiredAmount = requiredAmount;
        this.CoinReward = coins;

    }

    public override void Init()
    {
        base.Init();
        QuestEvents.EndEvent += ItemCollected;
    }

    void ItemCollected(IQuestID items)
    {
        if (items.ID == this.ItemID)
        {
            this.CurrentAmount++;
            Evaluate();
        }
    }
}
