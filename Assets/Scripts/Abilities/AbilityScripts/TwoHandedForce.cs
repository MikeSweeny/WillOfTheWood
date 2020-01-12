//FILE          :   TwoHandedForce.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
//NAME : TwoHandedForce
//PURPOSE : All the funcionality of the TwoHandedForce ability as a child of abilities
public class TwoHandedForce : Abilities
{
    private bool isActive { get; set; }
    private bool hasMissed { get; set; }
    WeaponStats stats;
    //Function : TwoHandedForce() : base() constructor 
    //DESCRIPTION : Constructor that sets the name,description, image, and unlocks the ability function
    //PARAMETERS : none
    //RETURNS : none
    public TwoHandedForce() : base()
    {
        abilityName = "TwoHandedForces";
        abilityDescription = "Increases Two-Handed max damage and BlackBlade min/max damage.";
        abilityImage = (Sprite)sprites[6];
        AbilityManager.UnlockTwoHandedForce += UnlockAbility;
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
        if (isActive && stats.weaponType == WeaponStats.weaponTypes.TWOHANDED)
        {
            stats.SetAttackMaxDamageModifier(2);
        }
        if (stats.weaponType == WeaponStats.weaponTypes.BLACKBLADE)
        {
            stats.SetAttackMinDamageModifier(2);
            stats.SetAttackMaxDamageModifier(2);
        }
    }
}
