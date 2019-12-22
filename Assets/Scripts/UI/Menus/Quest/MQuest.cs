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

    public GameObject questbuttonPrefab;

    private Transform detailsBox;
    private Transform buttonHolder;
    private Text title;
    private Text description;
    private Text requirements;
    private Text reward;
    private Quests selectedQuest;
    private List<UQuestButton> buttons;

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    private void Awake()
    {
        gameObject.SetActive(false);
        detailsBox = transform.Find("DescriptionHolder");
        title = detailsBox.Find("QuestTitleText").GetComponent<Text>();
        description = detailsBox.Find("DescriptionText").GetComponent<Text>();
        requirements = detailsBox.Find("RequirementsText").GetComponent<Text>();
        reward = detailsBox.Find("RewardsText").GetComponent<Text>();
        buttons = new List<UQuestButton>();
        UIEventManager.OpenQuests += OpenMenu;
        UIEventManager.OpenQuests += UpdateQuestList;
        UIEventManager.CloseQuests += CloseMenu;
        
    }


    //Function : Update
    //DESCRIPTION : updates the gameobject
    //PARAMETERS : none
    //RETURNS : none
    private void Update()
    {
        if (selectedQuest)
        {
            title.text = selectedQuest.QuestName;
            description.text = selectedQuest.Description;
            requirements.text = selectedQuest.QuestObjectives;
        }
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

    //Function : UpdateQuestList
    //DESCRIPTION : Checks to see if there are enough buttons for the active and completed quests
    // and if not adds some, then sets the buttons to represent said quests
    //PARAMETERS : none
    //RETURNS : none
    public void UpdateQuestList()
    {
        QuestManager qmRef = GameObject.Find("Managers").GetComponent<QuestManager>();
        if (buttons.Count < qmRef.ActiveQuest.Count)
        {
            int difference = buttons.Count - qmRef.ActiveQuest.Count;
            for (int i = 0; i < difference; ++i)
            {
                GameObject gObject = Instantiate(questbuttonPrefab);
                gObject.transform.SetParent(buttonHolder);
                buttons.Add(gObject.GetComponent<UQuestButton>());
            }
        }

        for (int i = 0; i < buttons.Count; ++i)
        {
            buttons[i].SetQuestMenuRef(this);
            buttons[i].SetQuest(qmRef.ActiveQuest[i]);
        }
    }
}
