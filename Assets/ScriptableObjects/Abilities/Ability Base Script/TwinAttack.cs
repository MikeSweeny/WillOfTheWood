//FILE          :   TwinAttack.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "TwinAttack()", menuName = "Abilities/TwinAttack")]
//NAME : TwinAttack
//PURPOSE : All the funcionality of the TwinAttack ability as a child of abilities

public class TwinAttack : Abilities
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
        if (isActive)
        {
            isNovice = true;
            //while activated the player can equip short weapons to his sheild arm and can attack twice(more animations needed for this style of combat)
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
            //while activated the player can equip one handed weapons to his sheild arm and can attack twice(more animations needed for this style of combat)
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
            //while activated the player can equip one handed weapons to his sheild arm and two handed weapons to his weapon arm 
            //can attack twice(more animations needed for this style of combat)
        }
    }
}
