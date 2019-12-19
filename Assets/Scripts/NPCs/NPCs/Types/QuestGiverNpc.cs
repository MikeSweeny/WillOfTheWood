//FILE: QuestGiverNpc.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 12/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME: QuestGiverNpc
//PURPOSE: this class is used to tell the quest givers what they are supposed to do when they are interacted with
public class QuestGiverNpc : BaseInteractableNpc
{
    //UI and Quests.cs to link to
    //QuestUIManager QUIM;
    QuestManager QM;
    public Quests Quest { get; set; }
    public bool AssignedQuest { get; set; } //Has quest been assigned
    public bool Helped { get; set; } //quest to hand in
    public List<Quests> QuestList = new List<Quests>(); //List of quests for NPC
    private int i = 0; //quest counter
    public bool isSecondaryNPC = false;



    void Awake()
    {
        //QUIM = FindObjectOfType<QuestUIManager>();
        QM = FindObjectOfType<QuestManager>();
    }
    //Function: OnInteract
    //DESCRIPTION: this function is used to say what the quest giver does when it is interacted with
    //PARAMETERS: None
    //RETURNS: None
    public override void OnInteract()
    {
        if (!isSecondaryNPC)
        {
            if (!AssignedQuest && !Helped)
            {
                //if (QUIM)
                //{
                //    QUIM.NPCBoxOne.text = "Welcome to Wonderland!";
                //    QUIM.NPCBoxTwo.text = "Will you please help me out with my quest?";
                //}

                AssignQuest();
            }
            else if (AssignedQuest && !Helped)
            {
                CheckQuest();
            }
            else
            {
                NextQuest();
            }
        }
        else if (isSecondaryNPC)
        {
            if(!Quest.Completed)
            {
            //what do you want!
            }
            else if (Quest.Completed)
            {
                //customized dialog
                Quest.GiveReward();
                QM.addToCQNList(Quest.QuestName);
                Quest.isActive = false;
                QM.RemoveActiveQuest(Quest);
                isSecondaryNPC = false;
            }

            
        }
    }

    //FUNCTION : AssignedQuest
    //DESCRIPTION : Assigns the quest to the player if needed
    void AssignQuest()
    {


        //checking to see if valid 

        for (int i = 0; i < QuestList.Count; i++)
        {
            if (!QM.searchCQNList(QuestList[i].QuestName))
            {
                if (QM.searchCQNList(QuestList[i].Prereq1) && QM.searchCQNList(QuestList[i].Prereq2))
                {
                    Quest = QuestList[i];

                    AssignedQuest = true;
                    Quest.Load();
                    Quest.StartText();
                    Quest.isActive = true;
                    QM.AddActiveQuests();
                    return;
                }
            }
        }
        //NoMoreQuest();
    }

    //FUNCTION : CheckQuest
    //DESCRIPTION : Checking to see if quest is done or not and assigning the correct dialoge/action
    void CheckQuest()
    {
        if (Quest.Completed && !Quest.SecondNPC)
        {
            Quest.GiveReward();
            Helped = true;
            AssignedQuest = false;
            QM.addToCQNList(Quest.QuestName);
            Quest.CompletedText();
            Quest.isActive = false;
            QM.RemoveActiveQuest(Quest);

        }
        else
        {
            Quest.InprogressText();
        }
    }

    //FUNCTION : NextQuest
    //DESCRIPTION : Calls the next quest in the line when the player revisits the questGiver
    void NextQuest()
    {
        i++;
        if (i >= QuestList.Count)
        {
            //NoMoreQuest();
        }
        else
        {
            Helped = false;
            AssignedQuest = false;
            AssignQuest();

        }
    }

    //FUNCTION : NoMoreQuest
    //DESCRIPTION : Calls the dialog if no more quests are to be found
    void NoMoreQuest()
    {
        //    if (QUIM)
        //    {
        //        QUIM.NPCBoxOne.text = "Welcome to Wonderland!";
        //        QUIM.NPCBoxTwo.text = "No Available Quests";
        //    }
        Debug.Log("No Quest Got");
    }
}
