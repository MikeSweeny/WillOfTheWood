//FILE          :   UQuestButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   20/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : UQuestButton
//PURPOSE : sets which quest is selected in the menu
public class UQuestButton : UIButton
{

    private Quests quest;
    private Text title; 
    private MQuest questMenuRef;


    //Function : Clicked
    //DESCRIPTION : calls the function in the quest menu that sets the selected quest
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        questMenuRef.SetQuest(quest);
    }

    //Function : SetQuest
    //DESCRIPTION : sets which quest the button represents
    //PARAMETERS : Quests aQuest : the quest the button is to represent
    //RETURNS : none
    public void SetQuest(Quests aQuest)
    {
        title = transform.Find("Text").GetComponent<Text>();
        title.text = aQuest.QuestName;
        quest = aQuest;
    }

    //Function : SetQuestMenuRef
    //DESCRIPTION : sets the reference to the quest menu
    //PARAMETERS : MQuest mQuest : the quest menu
    //RETURNS : none
    public void SetQuestMenuRef(MQuest mQuest)
    {
        questMenuRef = mQuest;
    }
}
