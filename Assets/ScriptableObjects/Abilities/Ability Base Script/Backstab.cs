//FILE          :   Backstab.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   17/12/2019

using UnityEngine;

[CreateAssetMenu(fileName = "Backstab()", menuName = "Abilities/Backstab")]
//NAME : Backstab
//PURPOSE : All the funcionality of the backstab ability as a child of abilities
public class Backstab : Abilities
{
    private bool isActive { get; set; }
    PlayerStats stats;
    ShortSwordStats dagger;
    //Function : OnLoad
    //DESCRIPTION : what happens when the script is loaded in the game
    //PARAMETERS : none
    //RETURNS : none
    public override void OnLoad()
    {
        AbilityManager.UnlockBackStab += UnlockAbility;
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