//FILE          :   ExceptionalAttribute.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "ExceptionalAttribute()", menuName = "Abilities/ExceptionalAttribute")]
//NAME : ExceptionalAttribute
//PURPOSE : All the funcionality of the ExceptionalAttribute ability as a child of abilities
public class ExceptionalAttribute : Abilities
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
        if (isActive)
        {
            isNovice = true;
            //if temporary:
            //have a HUD menu that shows the players stats that can be added to as buttons and when one is pressed, add 1 to that stat for x ammount of time
            //if permanent:
            //have a HUD menu that shows the players stats that can be added to as buttons and when one is pressed, add 1 to that stat.
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
            //if temporary:
            //have a HUD menu that shows the players stats that can be added to as buttons and when one is pressed, add 2 to that stat for x ammount of time
            //if permanent:
            //have a HUD menu that shows the players stats that can be added to as buttons and when one is pressed, add 2 to that stat.
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
            //if temporary:
            //have a HUD menu that shows the players stats that can be added to as buttons and when one is pressed, add 3 to that stat for x ammount of time
            //if permanent:
            //have a HUD menu that shows the players stats that can be added to as buttons and when one is pressed, add 3 to that stat.
        }
    }
}
