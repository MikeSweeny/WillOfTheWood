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
        AbilityManager.UnlockExceptionalAttribute += UnlockAbility;
    }
    public override void UpdateAbility()
    {
        if (isActive)
        {
            Act();
        }
    }
    //Function : Act
    //DESCRIPTION : what happens when the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void Act()
    {
        if (isActive)
        {
            //if temporary:
            //have a HUD menu that shows the players stats that can be added to as buttons and when one is pressed, add 1 to that stat for x ammount of time
            //if permanent:
            //have a HUD menu that shows the players stats that can be added to as buttons and when one is pressed, add 1 to that stat.
        }
    }
}
