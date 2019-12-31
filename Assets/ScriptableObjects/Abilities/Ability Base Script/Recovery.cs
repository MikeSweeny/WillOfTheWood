//FILE          :   Recovery.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "Recovery()", menuName = "Abilities/Recovery")]
//NAME : Recovery
//PURPOSE : All the funcionality of the Recovery ability as a child of abilities
public class Recovery : Abilities
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
        //if (isActive && stats.currentHealth != stats.maxHealth)
        //{
        //    isNovice = true;
        //    //random range between 1-4, integer returned is applied to player toughness
        //}
    }
    //Function : AdeptLevelAct
    //DESCRIPTION : what happens when the adept level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void AdeptLevelAct()
    {
        //if (isActive && stats.currentHealth != stats.maxHealth)
        //{
        //    isAdept = true;
        //    //random range between 1-6, integer returned is applied to player toughness
        //}
    }
    //Function : MasterLevelAct
    //DESCRIPTION : what happens when the master level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void MasterLevelAct()
    {
        //if (isActive && stats.currentHealth != stats.maxHealth)
        //{
        //    isMaster = true;
        //    //random range between 1-8, integer returned is applied to player toughness
        //}
    }
}
