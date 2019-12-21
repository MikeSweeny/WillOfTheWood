//FILE          :   Backstab.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   17/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Backstab", menuName = "Abilities/Backstab")]
//NAME : Backstab
//PURPOSE : All the funcionality of the backstab ability as a child of abilities
public class Backstab : Abilities
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
        stats.defence = stats.defence - 1;
        if(stats.defence <= 0)
        {
            stats.defence = 0;
        }

        if (stats.isDetected == false)
        {
            isNovice = true;
            AdditionalDamage();
        }
    }
    //Function : AdeptLevelAct
    //DESCRIPTION : what happens when the adept level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void AdeptLevelAct()
    {
        stats.defence = stats.defence - 1;
        if (stats.defence <= 0)
        {
            stats.defence = 0;
        }

        if (!stats.isDetected == false)
        {
            isAdept = true;
            AdditionalDamage();
        }
    }
    //Function : MasterLevelAct
    //DESCRIPTION : what happens when the master level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void MasterLevelAct()
    {
        if (!stats.isDetected == false)
        {
            isMaster = true;
            AdditionalDamage();

        }
    }
    //Function : AdditionalDamage
    //DESCRIPTION : adds additional damage in 2 different ways
    //PARAMETERS : none
    //RETURNS : none
    public void AdditionalDamage()
    {
        if(isNovice || isAdept)
        {
            Random.Range(1, 6);
        }
        else if (isMaster)
        {
            Random.Range(1, 8);
        }
    }
}