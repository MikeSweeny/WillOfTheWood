//FILE          :   Backstab.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   17/12/2019

using UnityEngine;

//NAME : Backstab
//PURPOSE : All the funcionality of the backstab ability as a child of abilities
public class Backstab : Abilities
{
    private bool isActive { get; set; }
    PlayerStats stats;
    ShortSwordStats dagger;
    //Function : Backstab() : base() constructor 
    //DESCRIPTION : Constructor that sets the name,description, image, and unlocks the ability function
    //PARAMETERS : none
    //RETURNS : none
    public Backstab() : base()
    {
        abilityName = "BackStab";
        abilityDescription = "Do extra damage while undetected.";
        abilityImage = (Sprite)sprites[43];
        AbilityManager.UnlockBackStab += UnlockAbility;
    }
    //Function: UpdateAbility()
    //DESCRIPTION: Override function for the UpdateAbility() function in base class
    //PARAMETERS: none
    //RETURNS: None
    public override void UpdateAbility()
    {
        if (isActive)
        {
            Act();
        }
    }
    //Function : Act()
    //DESCRIPTION : Override function for the act() base function
    //PARAMETERS : none
    //RETURNS : none
    public override void Act()
    {
        stats.defence = stats.defence - 1;
        if (stats.defence <= 0)
        {
            stats.defence = 0;
        }

        if (stats.isDetected == false)
        {
            dagger.AdditionalDamage();
        }
        dagger.ReSetAttackMaxDamage();
    }
}