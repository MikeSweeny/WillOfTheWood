//FILE          :   IronFist.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "IronFist()", menuName = "Abilities/IronFist")]
//NAME : IronFist
//PURPOSE : All the funcionality of the IronFist ability as a child of abilities
public class IronFist : Abilities
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
        //if (isActive && equippedWeapon == melee)
        //{
        isNovice = true;
        ////add 1/2 of strength stat to accuracy check when using melee attacks.
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
        //add strength stat to accuracy check when using melee attacks.
        //melee damage is now 1-6 instead of 1-4
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
        //add strength stat to accuracy check when using melee attacks.
        //melee damage is now 1-6 instead of 1-4
        //if the player lands another hit within 10 in game seconds, apply extra 1-4 damage on that attack.
        //}
    }
}
