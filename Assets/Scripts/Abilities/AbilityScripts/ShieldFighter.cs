//FILE          :   ShieldFighter.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
//NAME : ShieldFighter
//PURPOSE : All the funcionality of the ShieldFighter ability as a child of abilities
public class ShieldFighter : Abilities
{
    private bool isActive { get; set; }
    WeaponStats stats;
    //Function : ShieldFighter() : base() constructor 
    //DESCRIPTION : Constructor that sets the name,description, image, and unlocks the ability function
    //PARAMETERS : none
    //RETURNS : none
    public ShieldFighter() : base()
    {
        abilityName = "ShieldFighter";
        abilityDescription = "Not a working ability...";
        abilityImage = (Sprite)sprites[79];
        AbilityManager.UnlockShieldFighter += UnlockAbility;
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
        if (isActive && stats.weaponType == WeaponStats.weaponTypes.ONEHANDED)
        {
            stats.SetAttackMaxDamageModifier(2);
            //add to sheilds max defence, no shields made at this time.
        }
    }
}
