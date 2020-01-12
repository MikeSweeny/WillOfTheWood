//FILE          :   Poisoner.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
//NAME : Poisoner
//PURPOSE : All the funcionality of the Poisoner ability as a child of abilities
public class Poisoner : Abilities
{
    IWeapon equippedWeapon;
    private bool isActive { get; set; }

    //Function : Poisoner() : base() constructor 
    //DESCRIPTION : Constructor that sets the name,description, image, and unlocks the ability function
    //PARAMETERS : none
    //RETURNS : none
    public Poisoner() : base()
    {
        abilityName = "Poisoner";
        abilityDescription = "Add 1-4 extra damage to weapons when active. ";
        abilityImage = (Sprite)sprites[29];
        AbilityManager.UnlockPoisoner += UnlockAbility;
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
        if (isActive)
        {
            equippedWeapon.isPoisonous = true;
            if(equippedWeapon.isPoisonous)
            {
                equippedWeapon.AddPoisonDamageModifier();
            }
        }
        else
        {
            equippedWeapon.isPoisonous = false;
        }
    }
}
