//FILE          :   MLeveling.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   11/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : MLeveling
//PURPOSE : serves as the leveling menu
public class MLeveling : Menu
{
    private Text skillPointsCount;
    private Player player;
    private Abilities selectedAbility;
    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        skillPointsCount = transform.Find("PointHolder").Find("Text").GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        gameObject.SetActive(false);
        UIEventManager.OpenLeveling += OpenMenu;
        UIEventManager.CloseLeveling += CloseMenu;
        Transform holder = transform.Find("AbilityHolder");
        for (int i = 0; i < holder.childCount; ++i)
        {
            holder.GetChild(i).Find("Button").GetComponent<UAbilitySlotButton>().SetMLRef(this);
        }
    }

    //Function : Update
    //DESCRIPTION : updates the object every frame
    //PARAMETERS : none
    //RETURNS : none
    private void Update()
    {
        skillPointsCount.text = "" + player.GetStatPoints();
    }

    //Function : OnDestroy
    //DESCRIPTION : Called when the object is destroyed
    //PARAMETERS : none
    //RETURNS : none
    private void OnDestroy()
    {
        UIEventManager.OpenLeveling -= OpenMenu;
        UIEventManager.CloseLeveling -= CloseMenu;
    }

    public void SetSelectedAbility(Abilities ability)
    {
        selectedAbility = ability;
    }
}
