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
    //Function : Recovery() : base() constructor 
    //DESCRIPTION : Constructor that sets the name,description, image, and unlocks the ability function
    //PARAMETERS : none
    //RETURNS : none
    public Recovery() : base()
    {
        abilityName = "Recovery";
        abilityDescription = "Heal a random ammount between 1-4.";
        abilityImage = (Sprite)sprites[145];
        AbilityManager.UnlockRecovery += UnlockAbility;
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
        if (isActive)
        {
            stats.RecoverHealth();
        }
    }
}
