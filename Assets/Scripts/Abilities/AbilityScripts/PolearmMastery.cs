//FILE          :   PolearmMastery.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
//NAME : PolearmMastery
//PURPOSE : All the funcionality of the PolearmMastery ability as a child of abilities
public class PolearmMastery : Abilities
{
    WeaponStats stats;
    private bool isActive { get; set; }
    //Function : PolearmMastery() : base() constructor 
    //DESCRIPTION : Constructor that sets the name,description, image, and unlocks the ability function
    //PARAMETERS : none
    //RETURNS : none
    public PolearmMastery() : base()
    {
        abilityName = "PolearmMastery";
        abilityDescription = "LongSpears add 2 to maximum damage.";
        abilityImage = (Sprite)sprites[125];
        AbilityManager.UnlockPoleArmMastery += UnlockAbility;
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
        if (isActive && stats.weaponType == WeaponStats.weaponTypes.LONG)
        {
            stats.SetAttackMaxDamageModifier(2);
        }
    }
}
