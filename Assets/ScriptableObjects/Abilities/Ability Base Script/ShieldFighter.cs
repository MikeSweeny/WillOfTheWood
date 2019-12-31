//FILE          :   ShieldFighter.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "ShieldFighter()", menuName = "Abilities/ShieldFighter")]
//NAME : ShieldFighter
//PURPOSE : All the funcionality of the ShieldFighter ability as a child of abilities
public class ShieldFighter : Abilities
{
    private bool isActive { get; set; }
    Player stats;
    //Function : OnLoad
    //DESCRIPTION : what happens when the script is loaded in the game
    //PARAMETERS : none
    //RETURNS : none
    public override void OnLoad()
    {
        isActive = false;
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
        //if (isActive && equippedWeapon == oneHanded)
        //{
        //    isNovice = true;
        //    equippedWeapon adds 1 to its max range and equippedShield adds 2 to its defence max range.
        //}
    }
    //Function : AdeptLevelAct
    //DESCRIPTION : what happens when the adept level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void AdeptLevelAct()
    {
        //if (isActive && equippedWeapon == oneHanded)
        //{
        //    isAdept = true;
        //    equippedWeapon adds 1 to its max range and equippedShield adds 2 to its defence max range.
        //    if player lands succesfull hit, added shield bash attack deals extra 1-4 damage to enemy. 
        //}
    }
    //Function : MasterLevelAct
    //DESCRIPTION : what happens when the master level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void MasterLevelAct()
    {
        //if (isActive && equippedWeapon == oneHanded)
        //{
        //    isMaster = true;
        //    equippedWeapon adds 1 to its max range and equippedShield adds 2 to its defence max range.
        //    if player lands succesfull hit, added shield bash attack deals extra 1-6 damage to enemy. 
        //}
    }
}
