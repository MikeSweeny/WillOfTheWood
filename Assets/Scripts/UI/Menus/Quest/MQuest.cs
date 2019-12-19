//FILE          :   MQuest.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   11/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : MQuest
//PURPOSE : serves as the quest menu
public class MQuest : Menu
{

    private Transform detailsBox;
    private Text title;
    private Text description;
    private Text requirements;
    private Text reward;
    private Quests selectedQuest;

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        gameObject.SetActive(false);
        detailsBox = transform.Find("DescriptionHolder");
        title = detailsBox.Find("QuestTitleText").GetComponent<Text>();
        description = detailsBox.Find("DescriptionText").GetComponent<Text>();
        requirements = detailsBox.Find("RequirementsText").GetComponent<Text>();
        reward = detailsBox.Find("RewardsText").GetComponent<Text>();
        UIEventManager.OpenQuests += OpenMenu;
        UIEventManager.CloseQuests += CloseMenu;
    }


    //Function : Update
    //DESCRIPTION : updates the gameobject
    //PARAMETERS : none
    //RETURNS : none
    private void Update()
    {
        title.text = selectedQuest.QuestName;
        description.text = selectedQuest.Description;
        requirements.text = selectedQuest.QuestObjectives;
    }

    //Function : OnDestroy
    //DESCRIPTION : Called when the object is destroyed
    //PARAMETERS : none
    //RETURNS : none
    private void OnDestroy()
    {
        UIEventManager.OpenQuests -= OpenMenu;
        UIEventManager.CloseQuests -= CloseMenu;
    }


    //Function : SetQuest
    //DESCRIPTION : sets the selected quest to the quest provided
    //PARAMETERS : Quests quest: the quest the user wants to see
    //RETURNS : none
    public void SetQuest(Quests quest)
    {
        selectedQuest = quest;
    }
}
