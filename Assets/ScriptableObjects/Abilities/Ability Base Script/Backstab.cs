﻿//FILE          :   Backstab.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   17/12/2019

using UnityEngine;

[CreateAssetMenu(fileName = "Backstab()", menuName = "Abilities/Backstab")]
//NAME : Backstab
//PURPOSE : All the funcionality of the backstab ability as a child of abilities
public class Backstab : Abilities
{
    private bool isActive { get; set; }
    PlayerStats stats;
    WeaponStats weaponStats;
    //Function : OnLoad
    //DESCRIPTION : what happens when the script is loaded in the game
    //PARAMETERS : none
    //RETURNS : none
    public override void OnLoad()
    {
        isActive = false;
        if (isCollected)
        {
            if (isActive)
            {
                Act();
            }
        }
    }
    //Function : noviceLevelAct
    //DESCRIPTION : what happens when the novice level of the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void Act()
    {
        stats.defence = stats.defence - 1;
        if (stats.defence <= 0)
        {
            stats.defence = 0;
        }

        if (stats.isDetected == false)
        {
            AdditionalDamage();
        }
    }
}