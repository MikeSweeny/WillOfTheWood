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
    //Function : OnLoad
    //DESCRIPTION : what happens when the script is loaded in the game
    //PARAMETERS : none
    //RETURNS : none
    public Dominate()
    {
        abilityName = "Dominate";
        abilityDescription = " ";
        AbilityManager.UnlockDominate += UnlockAbility;
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
            //add persuasive stat to the accuracy check for attacking (combat not setup for this yet)
            stats.accuracy = stats.pursuasive + stats.accuracy;
        }
    }
}
