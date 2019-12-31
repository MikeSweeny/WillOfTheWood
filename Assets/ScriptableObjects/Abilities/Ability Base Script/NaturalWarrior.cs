//FILE          :   NaturalWarrior.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "NaturalWarrior()", menuName = "Abilities/NaturalWarrior")]
//NAME : NaturalWarrior
//PURPOSE : All the funcionality of the NaturalWarrior ability as a child of abilities
public class NaturalWarrior : Abilities
{
    private bool isActive { get; set; }
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
        //if (isActive && equippedWeapon == melee)
        //{
        isNovice = true;
        ////melee damage is now 1-6 instead of 1-4
        //}
    }
    //Function : AdeptLevelAct
    //DESCRIPTION : what happens when the adept level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void AdeptLevelAct()
    {
        //if (isActive && equippedWeapon == melee)
        //{
        isAdept = true;
        ////melee damage is now 1-6 instead of 1-4 and player strikes twice per attack
        //}
    }
    //Function : MasterLevelAct
    //DESCRIPTION : what happens when the master level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void MasterLevelAct()
    {
        //if (isActive && equippedWeapon == melee)
        //{
        isMaster = true;
        ////melee damage is now 2-12 instead of 1-4 and player strikes twice per attack
        //}
    }
}
