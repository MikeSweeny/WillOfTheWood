//FILE          :   SteadFast.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "SteadFast()", menuName = "Abilities/SteadFast")]
//NAME : SteadFast
//PURPOSE : All the funcionality of the SteadFast ability as a child of abilities
public class SteadFast : Abilities
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
        if (isActive)
        {
            isNovice = true;
            //stats.resistance = stats.resistance + 1
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
            //stats.resistance = stats.resistance + 2
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
            //stats.resistance = stats.resistance + 3
            //if (stats.resistance > 3 && attackingEnemyEquippedWeapon.statusEffect)
            //attacking enemy takes 1-6 damage
        }
    }
}
