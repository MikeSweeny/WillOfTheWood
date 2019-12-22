//FILE : TurnInQuests.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Rebecca Stewart
//FIRST VERSION : 19/12/2019
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Quest", menuName = "Quests/TurnInQuest")]

public class TurnInQuests : Quests
{
    public string NPCHandInName;
    public List<string> CNPC = new List<string>();
    
    public override void Load()
    {
        CurrentAmount = 0;
        Completed = false;
        Goals.Add(new TurnInQuest(this, NPCID, "Kill " + RequiredAmount + " " + NPCID, false, CurrentAmount, RequiredAmount, CoinReward, NPCHandInName));
        Goals.ForEach(g => g.Init());

        SecondNPC = true;
        NPCHandIn = GameObject.Find(NPCHandInName);
        if (NPCHandIn)
        {
            NPCHandIn.GetComponent<QuestGiverNpc>().isSecondaryNPC = true;
            NPCHandIn.GetComponent<QuestGiverNpc>().Quest = this;
        }
        for (int i = 0; i < CNPC.Count; i++)
        {
            GameObject NPC;
            NPC = GameObject.Find(CNPC[i]);
            if (NPC)
            {
                NPC.GetComponent<ConversationNpc>().hasBeenTalkedTo = false;
            }
        }

    }


    public override void StartText()
    {
        //QUIM = FindObjectOfType<QuestUIManager>();
        //if (QUIM)
        //{
        //    QUIM.NPCBoxTwo.text = StartQuestText;
        //}
        Debug.Log("StartText " + QuestName);
    }
    public override void TrackingQuest()
    {
        //QUIM = FindObjectOfType<QuestUIManager>();
        //if (QUIM)
        //{
        //    QUIM.TextDetails.text = TrackingQuestText;
        //    if (Completed)
        //    {
        //        QUIM.TextTally.text = "Completed";
        //    }
        //    else
        //    {
        //        QUIM.TextTally.text = this.CurrentAmount + " / " + RequiredAmount;
        //    }
        //}
        //Debug.Log("Tracking Quest" + QuestName);
    }
    public override void InprogressText()
    {
        //QUIM = FindObjectOfType<QuestUIManager>();
        //if (QUIM)
        //{
        //    QUIM.NPCBoxTwo.text = InprogressQuestText;
        //}
        Debug.Log("In Progress " + QuestName);
    }
    public override void CompletedText()
    {
        //QUIM = FindObjectOfType<QuestUIManager>();
        //if (QUIM)
        //{
        //    QUIM.NPCBoxTwo.text = CompletedQuestText;
        //}
        Debug.Log("Completed Text " + QuestName);
    }

    public override void GiveReward()
    {
        

        Debug.Log("Quest Reward Given.");
    }

}