//FILE          :   UAbilitySlotButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   10/01/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : UAbilitySlotButton
//PURPOSE : sets the selected ability in the leveling menu
//to the desired ability
public class UAbilitySlotButton : UIButton
{
    protected Abilities ability;
    private MLeveling mlRef;
    private Image image;

    //Function : Start
    //DESCRIPTION : called when the object is initialized after Awake
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        image = GetComponent<Image>();
        image.sprite = ability.abilityImage;
    }

    //Function : Clicked
    //DESCRIPTION : calls the function in the leveling menu
    //to set the selected ability
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        mlRef.SetSelectedAbility(ability);
    }

    //Function : SetMLRef
    //DESCRIPTION : sets the reference to the leveling menu
    //PARAMETERS : MLeveling menu : the menu being referenced
    //RETURNS : 
    public void SetMLRef(MLeveling menu)
    {
        mlRef = menu;
    }
}
