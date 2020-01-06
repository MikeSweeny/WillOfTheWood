//FILE          :   IWeapon.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   18/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : IWeapon
//PURPOSE : the base class for weapons
public class IWeapon : Item
{
    private int roll;
    protected WeaponStats stats;
    Collider collider;
    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    public void Awake()
    {
        itemType = ItemTypes.WEAPON;
        itemSprite = GetComponent<Image>();
    }

    public WeaponStats GetStats()
    {
        return stats;
    }
    public bool ToggleCollider(bool isActive)
    {
        if (isActive)
        {
            collider.gameObject.SetActive(true);
        }
        else
        {
            collider.gameObject.SetActive(false);
        }
        return isActive;
    }
    //Function : OnTriggerEnter
    //DESCRIPTION : checks the collider for the object being hit and applies damage to that object
    //PARAMETERS : none
    //RETURNS :none
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.root.tag != gameObject.transform.root.tag)
        {
            CharacterBase character = other.gameObject.GetComponent<CharacterBase>();
            character.TakeDamage(AttackRoll());
        }
    }
    //Function : OnTriggerEnter
    //DESCRIPTION : checks the weapons min and max damage and randomizes a number between them, takes that number and applies it as the roll.
    //PARAMETERS : attackMinDamage, attackMaxDamage
    //RETURNS : int roll
    public int AttackRoll()
    {
        roll = (int)Random.Range(stats.GetAttackMinDamage(), stats.GetAttackMaxDamage());
        return roll;
    }
}
