//FILE          :   Feign.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
//NAME : Feign
//PURPOSE : All the funcionality of the Feign ability as a child of abilities
public class Feign : Abilities
{
    public WeaponStats equippedWeapon;
    PlayerStats stats;
    private bool isActive { get; set; }
    //Function : Feign() : base() constructor 
    //DESCRIPTION : Constructor that sets the name,description, image, and unlocks the ability function
    //PARAMETERS : none
    //RETURNS : none
    public Feign() : base()
    {
        abilityName = "Feign";
        abilityDescription = "Chance to attack without being detected while active.";
        abilityImage = (Sprite)sprites[40];
        AbilityManager.UnlockFeign += UnlockAbility;
    }
    //Function: UpdateAbility()
    //DESCRIPTION: Override function for the UpdateAbility() function in base class
    //PARAMETERS: none
    //RETURNS: None
    public override void UpdateAbility()
    {
        if (isActive)
        {
            Act();
        }
    }

    //Function : Act()
    //DESCRIPTION : Override function for the act() base function
    //PARAMETERS : none
    //RETURNS : none
    public override void Act()
    {
        if (isActive && equippedWeapon.weaponType == WeaponStats.weaponTypes.DAGGER)
        {
            //random range between 1 - 10, if the integer returned is > 5, apply 1 - 4 damage to enemy and the enemy stays idle. otherwise enemy detects and attacks.
            int RR;
            RR = Random.Range(1, 10);
            if(RR >= 5)
            {
                //apply 1-4 damage to enemy
                stats.isDetected = false;
            }
            else
            {
                stats.isDetected = true;
                isActive = false;
            }
        }
    }
}
