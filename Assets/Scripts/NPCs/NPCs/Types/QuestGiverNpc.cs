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
    QuestManager QM;
    public Quests Quest { get; set; }
    public bool AssignedQuest { get; set; } //Has quest been assigned
    public bool Helped { get; set; } //quest to hand in
    public List<Quests> QuestList = new List<Quests>(); //List of quests for NPC
    private int i = 0; //quest counter
    public bool isSecondaryNPC = false;
    private string currentText = "";
    public AudioSource source;



    void Awake()
    {
        QM = FindObjectOfType<QuestManager>();
        setStats();
        source = GetComponent<AudioSource>();
    }
    //Function: OnInteract
    //DESCRIPTION: this function is used to say what the quest giver does when it is interacted with
    //PARAMETERS: None
    //RETURNS: None
    public override void OnInteract()
    {
        if (source)
            source.Play();
        if (!isSecondaryNPC)
        {
            UIEventManager.TriggerOpenDialogue();

            if (!AssignedQuest && !Helped)
            {
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
            UIEventManager.TriggerOpenDialogue();
            if (!Quest.Completed)
            {
            currentText = Quest.SecondInprogressText;
            }
            else if (Quest.Completed)
            {
                currentText = Quest.SecondCompletedText;
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
                    currentText = Quest.StartQuestText;
                    Quest.isActive = true;
                    QM.AddActiveQuests(Quest);
                    return;
                }
            }
        }
        NoMoreQuest();
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
            currentText = Quest.CompletedQuestText;
            Quest.isActive = false;
            QM.RemoveActiveQuest(Quest);

        }
        else if (Quest.Completed && Quest.SecondNPC)
        {
            currentText = Quest.CompletedQuestText;
        }
        else
        {
            currentText = Quest.InprogressQuestText;
        }
    }

    //FUNCTION : NextQuest
    //DESCRIPTION : Calls the next quest in the line when the player revisits the questGiver
    void NextQuest()
    {
        i++;
        if (i >= QuestList.Count)
        {
           NoMoreQuest();
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
        currentText = "Thanks for you Help";
        Debug.Log("No Quest Got");
    }

    public override string GetCurrentText()
    {
        return currentText;
    }

    public override void NextDialogue()
    {
        UIEventManager.TriggerCloseDialogue();
    }

}
