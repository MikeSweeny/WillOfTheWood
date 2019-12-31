//FILE          :   PolearmMastery.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "PolearmMastery()", menuName = "Abilities/PolearmMastery")]
//NAME : PolearmMastery
//PURPOSE : All the funcionality of the PolearmMastery ability as a child of abilities
public class PolearmMastery : Abilities
{
    private bool isActive { get; set; }
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
        //if (isActive && equippedWeapon == Long)
        //{
        isNovice = true;
        ////Equipped long weapon goes up a tier, staves 1-8 and all other long weapons equipped doing 1-10
        //}
    }
    //Function : AdeptLevelAct
    //DESCRIPTION : what happens when the adept level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void AdeptLevelAct()
    {
        //if (isActive && equippedWeapon == Long)
        //{
        isAdept = true;
        ////Equipped long weapon goes up a tier, staves 1-8 and all other long weapons equipped doing 1-10. Player attacks twice per attack
        //}
    }
    //Function : MasterLevelAct
    //DESCRIPTION : what happens when the master level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void MasterLevelAct()
    {
        //if (isActive && equippedWeapon == Long)
        //{
        isMaster = true;
        ////Equipped long weapon goes up a tier, staves 1-8 and all other long weapons equipped doing 1-10. Player attacks twice per attack
        ////when active and attacking, even if player doesnt hit, enemies cannot get close enough to attack with anything but designated 'long' weaponary.
        //}
    }
}
