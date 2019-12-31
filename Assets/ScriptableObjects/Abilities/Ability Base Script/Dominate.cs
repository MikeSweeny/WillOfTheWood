//FILE          :   Dominate.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "Dominate()", menuName = "Abilities/Dominate")]
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
    public override void OnLoad()
    {
        if (isCollected)
        {
            if (isNovice)
            {
                if (isActive)
                {
                    NoviceLevelAct();
                }
            }
            else if (isAdept)
            {
                if (isActive)
                {
                    AdeptLevelAct();
                }
            }
            else if (isMaster)
            {
                if (isActive)
                {
                    MasterLevelAct();
                }
            }
        }
    }
    //Function : noviceLevelAct
    //DESCRIPTION : what happens when the novice level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void NoviceLevelAct()
    {
        if (isActive)
        {
            isNovice = true;
            //add persuasive stat to the accuracy check for attacking (combat not setup for this yet)
        }
    }
    //Function : AdeptLevelAct
    //DESCRIPTION : what happens when the adept level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void AdeptLevelAct()
    {
        if (isActive)
        {
            isAdept = true;
            //add persuasive stat to the accuracy check for attacking (combat not setup for this yet)
            //check to see if another enemy is within range, if true, apply 1-4 damage to other enemy player is currently not attacking that is within range.
        }
    }
    //Function : MasterLevelAct
    //DESCRIPTION : what happens when the master level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void MasterLevelAct()
    {
        if (isActive)
        {
            isMaster = true;
            //add persuasive stat to the accuracy check for attacking (combat not setup for this yet)
            //check to see if another enemy is within range, if true, apply 1-4 damage to other enemy player is currently not attacking that is within range.
            //if another enemy takes dominate damage, random range between 1-10, if integer output is > 5, enemies flee for 25 in game seconds.
        }
    }
}
