//FILE          :   PolearmMastery.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "PolearmMastery()", menuName = "Abilities/PolearmMastery")]
//NAME : PolearmMastery
//PURPOSE : All the funcionality of the PolearmMastery ability as a child of abilities
public class PolearmMastery : Abilities
{
    WeaponStats stats;
    private bool isActive { get; set; }
    //Function : OnLoad
    //DESCRIPTION : what happens when the script is loaded in the game
    //PARAMETERS : none
    //RETURNS : none
    public PolearmMastery()
    {
        AbilityManager.UnlockPoleArmMastery += UnlockAbility;
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
        if (isActive && stats.weaponType == WeaponStats.weaponTypes.LONG)
        {
            stats.SetAttackMaxDamageModifier(2);
        }
    }
}
