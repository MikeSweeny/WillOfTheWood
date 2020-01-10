//FILE          :   AtArms.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   30/12/2019

using UnityEngine;
//NAME : AtArms
//PURPOSE : All the funcionality of the AtArms ability as a child of abilities
public class AtArms : Abilities
{
    ArmorStats armour;
    private bool isActive { get; set; }
    //Function : OnLoad
    //DESCRIPTION : what happens when the script is loaded in the game
    //PARAMETERS : none
    //RETURNS : none
    public AtArms()
    {
        AbilityManager.UnlockAtArms += UnlockAbility;
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
    //    if(armour.armourType == ArmorStats.armourTypes.LIGHT)
    //    {
    //        armour.SetMaxDefenceStats(6);
    //    }
    //    if (armour.armourType == ArmorStats.armourTypes.MEDIUM)
    //    {
    //        armour.SetMaxDefenceStats(8);
    //    }
    //    if (armour.armourType == ArmorStats.armourTypes.HEAVY)
    //    {
    //        armour.SetMaxDefenceStats(10);
    //    }
    //}
}
