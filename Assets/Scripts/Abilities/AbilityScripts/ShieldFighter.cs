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
    //Function : OnLoad
    //DESCRIPTION : what happens when the script is loaded in the game
    //PARAMETERS : none
    //RETURNS : none
    public ShieldFighter()
    {
        abilityName = "ShieldFighter";
        abilityDescription = " ";
        AbilityManager.UnlockShieldFighter += UnlockAbility;
    }
    public override void UpdateAbility()
    {
        if (isActive)
        {
            Act();
        }
    }
    //Function : noviceLevelAct
    //DESCRIPTION : what happens when the spell is used
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
