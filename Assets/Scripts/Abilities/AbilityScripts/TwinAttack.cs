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
    //Function : OnLoad
    //DESCRIPTION : what happens when the script is loaded in the game
    //PARAMETERS : none
    //RETURNS : none
    public TwinAttack()
    {
        abilityName = "TwinAttack";
        abilityDescription = "Not a working ability...";
        abilityImage = sprites[41];
        if (isActive)
        {
            Act();
        }
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
            //while activated the player can equip short or one-handed weapons to his sheild arm and can attack twice(more animations needed for this style of combat)
        }
    }
}
