//FILE          :   HObjectiveTracker.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   17/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : HObjectiveTracker
//PURPOSE : displays current objective for tracked quest
public class HObjectiveTracker : HUDElement
{
    private QuestManager qmRef;
    private Text counter;
    private Text description;

    private void Awake()
    {
        qmRef = GameObject.Find("Managers").GetComponent<QuestManager>();
        counter = transform.Find("Counter").GetComponent<Text>();
        description = counter.transform.GetChild(0).GetComponent<Text>();
    }


    //Function : UpdateElement
    //DESCRIPTION : Updates the relevant information to the element
    //PARAMETERS : none
    //RETURNS : none
    public override void UpdateElement()
    {
        if (qmRef.TrackingQuest != null)
        {
            //description.text = qmRef.TrackingQuest.
        }
    }
}
