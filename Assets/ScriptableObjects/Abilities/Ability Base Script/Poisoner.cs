//FILE          :   Poisoner.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "Poisoner()", menuName = "Abilities/Poisoner")]
//NAME : NaturalWarrior
//PURPOSE : All the funcionality of the NaturalWarrior ability as a child of abilities
public class Poisoner : Abilities
{
    IWeapon equippedWeapon;
    private bool isActive { get; set; }
    //Function : OnLoad
    //DESCRIPTION : what happens when the script is loaded in the game
    //PARAMETERS : none
    //RETURNS : none
    public Poisoner()
    {
        AbilityManager.UnlockPoisoner += UnlockAbility;
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
