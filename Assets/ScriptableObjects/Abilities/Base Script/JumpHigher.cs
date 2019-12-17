using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New JHPassive", menuName = "Abilities/JumpHigherPassive")]
public class JumpHigher : Abilities
{
    PlayerController player;
    public override void OnLoad()
    {
        if(isCollected)
        {
            if (isNovice)
            {
                noviceLevelAct();
            }
            else if (isAdept)
            {
                adeptLevelAct();
            }
            else if (isMaster)
            {
                masterLevelAct();
            }
        }
    }
    public override void noviceLevelAct()
    {
        player.jumpSpeed = 77.0f;
    }
    public override void adeptLevelAct()
    {
        player.jumpSpeed = 79.0f;
    }
    public override void masterLevelAct()
    {
        player.jumpSpeed = 83.0f;
    }
}
