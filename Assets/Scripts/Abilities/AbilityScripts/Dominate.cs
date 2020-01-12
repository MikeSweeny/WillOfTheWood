//FILE          :   Dominate.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
//NAME : Dominate
//PURPOSE : All the funcionality of the dominate ability as a child of abilities
public class Dominate : Abilities
{
    private bool isActive { get; set; }
    PlayerStats stats;
    //Function : Dominate() : base() constructor 
    //DESCRIPTION : Constructor that sets the name,description, image, and unlocks the ability function
    //PARAMETERS : none
    //RETURNS : none
    public Dominate() : base()
    {
        abilityName = "Dominate";
        abilityDescription = "Persuasive stat is added to accuracy check.";
        abilityImage = (Sprite)sprites[38];
        AbilityManager.UnlockDominate += UnlockAbility;
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
            //add persuasive stat to the accuracy check for attacking (combat not setup for this yet)
            stats.accuracy = stats.pursuasive + stats.accuracy;
        }
    }
}
