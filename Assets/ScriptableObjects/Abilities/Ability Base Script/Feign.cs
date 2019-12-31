//FILE          :   Feign.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "Feign()", menuName = "Abilities/Feign")]
//NAME : Feign
//PURPOSE : All the funcionality of the Feign ability as a child of abilities
public class Feign : Abilities
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
        //if (isActive && equippedWeapon == short)
        //{
            isNovice = true;
            //random range between 1 - 10, if the integer returned is > 5, apply 1-4 damage to enemy and the enemy stays idle. otherwise enemy detects and attacks.
        //}
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
            //random range between 1 - 10, if the integer returned is > 3, apply 1-4 damage to enemy and the enemy stays idle. otherwise enemy detects and attacks.
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
            //random range between 1 - 10, if the integer returned is > 3, apply 2-8 damage to enemy and the enemy stays idle. otherwise enemy detects and attacks.
        }
    }
}
