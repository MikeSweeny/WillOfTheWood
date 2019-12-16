//FILE : QuestManager.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Jonathan Parsons
//FIRST VERSION : 07/12/2019

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : QuestManager
//PURPOSE :Checks to see what Quests have been done and what quests can be unlocked because of the completed quests. 
public class QuestManager: MonoBehaviour
{
    public List<string> completedQuestNames;
    private bool isMatch = false;
    private bool isActive = false;
    private bool checklist;

    public List<string> ActiveQuest;
    public List<GameObject> QuestNPC = new List<GameObject>();
    
    

    //FUNCTION : searchCGNList()
    //DESCRIPTION : Searchs the completed Quest Names list.
    //PARAMETERS : 
    //RETURNS : None()
    public void Awake()
    {
        addToCQNList("NULL");
        ActiveQuest.Add("NULL");
        //find all quest givers
        QuestNPC.AddRange(GameObject.FindGameObjectsWithTag("QuestGiver"));
    }
    public bool searchCQNList(string name)
    {
        for (int i = 0; i < completedQuestNames.Count; i++)
        {
            if(name == completedQuestNames[i])
            {
                isMatch = true;
                break;
            }
            else
            {
                isMatch = false;
            }
        }
        return isMatch;
    }
    //FUNCTION : addCGNList()
    //DESCRIPTION : Adds to the completed Quest Names list.
    //PARAMETERS : 
    //RETURNS : None()
    public void addToCQNList(string addName)
    {
        completedQuestNames.Add(addName);
        Debug.Log(addName);
    }

    private void FixedUpdate()
    {
       // ActiveQuests();
    }

    public void AddActiveQuests()
    {

        for (int i = 0; i < QuestNPC.Count; i++)
        {
            isActive = QuestNPC[i].GetComponent<QuestGiverNpc>().Quest.isActive;
            if (isActive == true)
            {

                for (int j = 0; j < ActiveQuest.Count; j++)
                {
                    if (ActiveQuest[j] == QuestNPC[i].GetComponent<QuestGiverNpc>().Quest.QuestName)
                    {
                        checklist = true;
                        break;
                    }
                    else
                        checklist = false;
                }

                if (checklist == false)
                    ActiveQuest.Add(QuestNPC[i].GetComponent<QuestGiverNpc>().Quest.QuestName);

                
            }
        }
    }

    public void RemoveActiveQuest(string name)
    {
        for (int j = 0; j < ActiveQuest.Count; j++)
        {
            if (ActiveQuest[j] == name)
            {
                checklist = true;
                break;
            }
            else
                checklist = false;
        }

        if (checklist == true)
            ActiveQuest.Remove(name);
    }


}
