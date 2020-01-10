//FILE          :   Recovery.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
//NAME : Recovery
//PURPOSE : All the funcionality of the Recovery ability as a child of abilities
public class Recovery : Abilities
{
    private bool isActive { get; set; }
    CharacterBase stats;
    //Function : OnLoad
    //DESCRIPTION : what happens when the script is loaded in the game
    //PARAMETERS : none
    //RETURNS : none
    public Recovery()
    {
        abilityName = "Recovery";
        abilityDescription = "Heal a random ammount between 1-4.";
        abilityImage = sprites[140];
        AbilityManager.UnlockRecovery += UnlockAbility;
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
            stats.RecoverHealth();
        }
    }
}
