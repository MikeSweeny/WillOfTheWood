//FILE          :   AtArms.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   30/12/2019

using UnityEngine;
[CreateAssetMenu(fileName = "AtArms() ", menuName = "Abilities/AtArms")]
//NAME : AtArms
//PURPOSE : All the funcionality of the AtArms ability as a child of abilities
public class AtArms : Abilities
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
            //if(armor equipped == light)
            //{
                //armor stats now 1-6;
            //}
            //else if(armor equipped == medium)
            //{
                //armor stats now 1-8;
            //}
            //else if(armor equipped == heavy)
            //{
                //armor stats now 1-10;
            //}
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
            //if(armor equipped == light)
            //{
                //armor stats now 1-6;
            //}
            //else if(armor equipped == medium)
            //{
                //armor stats now 1-8;
            //}
            //else if(armor equipped == heavy)
            //{
                //armor stats now 1-10;
            //}
            //if(enemyHit && wearingArmor)
            //{
                //random range between 1 - 10
                //if(integer returned > 5)
                //{
                    //knock back enemy by moving its position negative in the 'z' axis a few spaces.
                //}
            //}
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
            //if(armor equipped == light)
            //{
                //armor stats now 1-6;
            //}
            //else if(armor equipped == medium)
            //{
                //armor stats now 1-8;
            //}
            //else if(armor equipped == heavy)
            //{
                //armor stats now 1-10;
            //}
            //if(enemyHit && wearingArmor)
            //{
                //random range between 1 - 10
                //if(integer returned > 5)
                //{
                    //knock back enemy by moving its position negative in the 'z' axis a few spaces.
                //}
            //}
            //if(armoredEnemy)
            //{
                //negate enemy armor stats when applying damage
            //}
        }
    }
}
