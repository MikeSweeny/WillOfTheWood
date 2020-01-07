//FILE          :   Feign.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
[CreateAssetMenu(fileName = "Feign()", menuName = "Abilities/Feign")]
//NAME : Feign
//PURPOSE : All the funcionality of the Feign ability as a child of abilities
public class Feign : Abilities
{
    public WeaponStats equippedWeapon;
    private bool isActive { get; set; }
    //Function : OnLoad
    //DESCRIPTION : what happens when the script is loaded in the game
    //PARAMETERS : none
    //RETURNS : none
    public override void OnLoad()
    {
        if (isCollected)
        {
            if (isActive)
            {
                Act();
            }
        }
    }
    //Function : Act
    //DESCRIPTION : what happens when the spell is used
    //PARAMETERS : none
    //RETURNS : none
    public override void Act()
    {
        //if (isActive && equippedWeapon.)
        //{
        //    random range between 1 - 10, if the integer returned is > 5, apply 1 - 4 damage to enemy and the enemy stays idle. otherwise enemy detects and attacks.
        //}
    }
}
