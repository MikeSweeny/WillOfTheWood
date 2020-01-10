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
    //Function : OnLoad
    //DESCRIPTION : what happens when the script is loaded in the game
    //PARAMETERS : none
    //RETURNS : none
    public TwoHandedForce()
    {
        abilityName = "TwoHandedForces";
        abilityDescription = " ";
        AbilityManager.UnlockTwoHandedForce += UnlockAbility;
    }
    public override void UpdateAbility()
    {
        if (isActive)
        {
            Act();
        }
    }
    //Function : Act
    //DESCRIPTION : what happens when the spell is used
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
