//FILE          :   TwoHandedForce.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "TwoHandedForce()", menuName = "Abilities/TwoHandedForce")]
//NAME : TwoHandedForce
//PURPOSE : All the funcionality of the TwoHandedForce ability as a child of abilities
public class TwoHandedForce : Abilities
{
    private bool isActive { get; set; }
    private bool hasMissed { get; set; }
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
        //if (isActive && equippedWeapon == TwoHanded)
        //{
            isNovice = true;
        //    equippedWeapon damage is now 1-12 instead of 1-10
        //    if equippedWeapon == BlackBlade, add 2 to min and max damage range
        //}
    }
    //Function : AdeptLevelAct
    //DESCRIPTION : what happens when the adept level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void AdeptLevelAct()
    {
        //if (isActive && equippedWeapon == TwoHanded)
        //{
        isAdept = true;
        //    equippedWeapon damage is now 1-12 instead of 1-10
        //    if equippedWeapon == BlackBlade, add 2 to min and max damage range
        //    if player attack misses while activated, hasMissed = true
        //    if hasMissed, next attack landed deals additional 1-6 damage
        //}
    }
    //Function : MasterLevelAct
    //DESCRIPTION : what happens when the master level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void MasterLevelAct()
    {
        //if (isActive && equippedWeapon == TwoHanded)
        //{
        isMaster = true;
        //    equippedWeapon damage is now 1-12 instead of 1-10
        //    if equippedWeapon == BlackBlade, add 2 to min and max damage range
        //    if player attack misses while activated, hasMissed = true
        //    if hasMissed, next attack landed deals additional 1-6 damage
        //    bypass enemy armor checks on successfull attack landed
        //}
    }
}
