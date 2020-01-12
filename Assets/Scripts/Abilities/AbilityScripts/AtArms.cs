//FILE          :   AtArms.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   30/12/2019

using UnityEngine;
using UnityEditor;

//NAME : AtArms
//PURPOSE : All the funcionality of the AtArms ability as a child of abilities
public class AtArms : Abilities
{
    ArmorStats armour;
    private bool isActive { get; set; }
    //Function : AtArms() : base() constructor 
    //DESCRIPTION : Constructor that sets the name,description, image, and unlocks the ability function
    //PARAMETERS : none
    //RETURNS : none
    public AtArms() : base()
    {
        abilityName = "AtArms";
        abilityDescription = "Changes armour rating to next tier of armour.";
        abilityImage = (Sprite)sprites[46];
        AbilityManager.UnlockAtArms += UnlockAbility;
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
    //DESCRIPTION :AtArms override function for the act() base function
    //PARAMETERS : none
    //RETURNS : none
    public override void Act()
    {
        if (armour.armourType == ArmorStats.armourTypes.LIGHT)
        {
            armour.SetMaxDefenceStats(6);
        }
        if (armour.armourType == ArmorStats.armourTypes.MEDIUM)
        {
            armour.SetMaxDefenceStats(8);
        }
        if (armour.armourType == ArmorStats.armourTypes.HEAVY)
        {
            armour.SetMaxDefenceStats(10);
        }
    }
}
