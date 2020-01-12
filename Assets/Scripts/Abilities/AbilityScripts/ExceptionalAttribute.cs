//FILE          :   ExceptionalAttribute.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
//NAME : ExceptionalAttribute
//PURPOSE : All the funcionality of the ExceptionalAttribute ability as a child of abilities
public class ExceptionalAttribute : Abilities
{
    private bool isActive { get; set; }
    //Function :  : base() constructor 
    //DESCRIPTION : Constructor that sets the name,description, image, and unlocks the ability function
    //PARAMETERS : none
    //RETURNS : none
    public ExceptionalAttribute() : base()
    {
        abilityName = "ExceptionalAttribute";
        abilityDescription = "Add 1 point to any stat.";
        abilityImage = (Sprite)sprites[156];
        AbilityManager.UnlockExceptionalAttribute += UnlockAbility;
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
            //if temporary:
            //have a HUD menu that shows the players stats that can be added to as buttons and when one is pressed, add 1 to that stat for x ammount of time
            //if permanent:
            //have a HUD menu that shows the players stats that can be added to as buttons and when one is pressed, add 1 to that stat.
        }
    }
}
