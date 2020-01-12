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

    //Function : Berserker() : base() constructor 
    //DESCRIPTION : Constructor that sets the name,description, image, and unlocks the ability function
    //PARAMETERS : none
    //RETURNS : none
    public Berserker() : base()
    {
        abilityName = "Berseker";
        abilityDescription = "Base Defence lowered by 2, equipped weapon has additional 1-6 damage.";
        abilityImage = (Sprite)sprites[35];
        AbilityManager.UnlockBerserker += UnlockAbility;
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
        stats.defence = stats.defence - 2;
        if (stats.defence <= 0)
        {
            stats.defence = 0;
        }
        equippedWeapon.SetAttackMinDamageModifier(1);
        equippedWeapon.SetAttackMaxDamageModifier(6);
    }
}
