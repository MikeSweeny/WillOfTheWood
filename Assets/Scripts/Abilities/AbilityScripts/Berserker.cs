//FILE          :   Berserker.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   30/12/2019

using UnityEngine;
//NAME : Berserker
//PURPOSE : All the funcionality of the berserker ability as a child of abilities
public class Berserker : Abilities
{
    public WeaponStats equippedWeapon;
    private bool isActive { get; set; }
    PlayerStats stats;
    //Function : OnLoad
    //DESCRIPTION : what happens when the script is loaded in the game
    //PARAMETERS : none
    //RETURNS : none
    public Berserker() : base()
    {
        abilityName = "Berseker";
        abilityDescription = "Base Defence lowered by 2, equipped weapon has additional 1-6 damage.";
        abilityImage = (Sprite)sprites[35];
        AbilityManager.UnlockBerserker += UnlockAbility;
    }
    public override void UpdateAbility()
    {
        if (isActive)
        {
            Act();
        }
    }
    //Function : noviceLevelAct
    //DESCRIPTION : what happens when the novice level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void Act()
    {
        stats.defence = stats.defence - 2;
        if (stats.defence <= 0)
        {
            stats.defence = 0;
        }
        equippedWeapon.SetAttackMinDamageModifier(1);
        equippedWeapon.SetAttackMaxDamageModifier(6);
    }
}
