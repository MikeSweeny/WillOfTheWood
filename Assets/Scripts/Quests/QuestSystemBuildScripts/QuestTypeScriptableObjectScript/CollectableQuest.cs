﻿//FILE : CollectableQuest.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : 06/12/2019

using UnityEngine;

[CreateAssetMenu(fileName = "New Quest", menuName = "Quests/Collectable")]
//NAME : CollectableQuest
//PURPOSE : Holds the requirments for the collectable quest
public class CollectableQuest : Quests
{
    public override void Load()
    {
        CurrentAmount = 0;
        Completed = false;
        Goals.Add(new CollectingQuest(this, NPCID, "Kill " + RequiredAmount + " " + NPCID, false, CurrentAmount, RequiredAmount, CoinReward));
        Goals.ForEach(g => g.Init());
    }


    public override void StartText()
    {
        //QUIM = FindObjectOfType<QuestUIManager>();
        //if (QUIM)
        //{
        //    QUIM.NPCBoxTwo.text = StartQuestText;
        //}
    }
    public override void TrackingQuest()
    {
        //QUIM = FindObjectOfType<QuestUIManager>();
        //if (QUIM)
        //{
        //    QUIM.TextDetails.text = TrackingQuestText;
        //    QUIM.TextTally.text = this.CurrentAmount + " / " + RequiredAmount;
        //}
    }
    public override void InprogressText()
    {
        //QUIM = FindObjectOfType<QuestUIManager>();
        //if (QUIM)
        //{
        //    QUIM.NPCBoxTwo.text = InprogressQuestText;
        //}
    }
    public override void CompletedText()
    {
        //QUIM = FindObjectOfType<QuestUIManager>();
        //if (QUIM)
        //{
        //    QUIM.NPCBoxTwo.text = CompletedQuestText;
        //}
    }
}