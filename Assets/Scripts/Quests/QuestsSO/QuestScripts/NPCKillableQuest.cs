using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Quest", menuName = "Quests/NPCKillable")]
public class NPCKillableQuest : Quests
{
    
    public override void Load()
    {
        CurrentAmount = 0;
        Completed = false;
        Goals.Add(new NPCKillQuest(this, NPCID, "Kill " + RequiredAmount + " " + NPCID, false, CurrentAmount, RequiredAmount, CoinReward, NPCKill));
        Goals.ForEach(g => g.Init());
        NPCtoKill = GameObject.Find(NPCKilled);
        if (NPCtoKill)
        {
            NPCtoKill.tag = "Enemy"; // and disable the quest giver script and enable the enemy script
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
        Debug.Log("Tracking Quest" + QuestName);
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





}
