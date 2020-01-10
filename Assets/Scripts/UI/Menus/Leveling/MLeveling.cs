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
    private Text abilityName;
    private Text abilityDescription;

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
        holder = transform.Find("AbilityInfoHolder");
        abilityName = holder.Find("AbilityNameText").GetComponent<Text>();
        abilityDescription = holder.Find("AbilityDescriptionText").GetComponent<Text>();
    }

    //Function : Update
    //DESCRIPTION : updates the object every frame
    //PARAMETERS : none
    //RETURNS : none
    private void Update()
    {
        skillPointsCount.text = "" + player.GetStatPoints();
        if (selectedAbility != null)
        {
            abilityName.text = selectedAbility.abilityName;
            abilityDescription.text = selectedAbility.abilityDescription;
        }
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

    //Function : SetSelectedAbility
    //DESCRIPTION : sets the selected ability reference
    //PARAMETERS : Abilities ability : the ability being referenced
    //RETURNS : none
    public void SetSelectedAbility(Abilities ability)
    {
        selectedAbility = ability;
    }
}
