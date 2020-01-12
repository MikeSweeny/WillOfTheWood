//FILE          :   TwinAttack.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
//NAME : TwinAttack
//PURPOSE : All the funcionality of the TwinAttack ability as a child of abilities

public class TwinAttack : Abilities
{
    private bool isActive { get; set; }
    //Function : TwinAttack() : base() constructor 
    //DESCRIPTION : Constructor that sets the name,description, image, and unlocks the ability function
    //PARAMETERS : none
    //RETURNS : none
    public TwinAttack() : base()
    {
        abilityName = "TwinAttack";
        abilityDescription = "Not a working ability...";
        abilityImage = (Sprite)sprites[42];
        AbilityManager.UnlockTwinAttack += UnlockAbility;
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
            //while activated the player can equip short or one-handed weapons to his sheild arm and can attack twice(more animations needed for this style of combat)
        }
    }
}
