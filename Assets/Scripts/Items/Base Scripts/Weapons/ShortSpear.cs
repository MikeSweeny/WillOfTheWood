﻿//FILE          :   ShortSpear.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   7/1/2020
using UnityEngine;

//NAME : ShortSpear
//PURPOSE : The child class of iWeapon for the shortspear weapon
public class ShortSpear : IWeapon
{
    CharacterBase character;
    private int roll;

    //Function : start
    //DESCRIPTION : sets the stats for shortspear on start
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        stats = new ShortSpearStats();
    }
    //Function : OnTriggerEnter
    //DESCRIPTION : checks the collider for the object being hit and applies damage to that object
    //PARAMETERS : none
    //RETURNS :none
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.root.tag != gameObject.transform.root.tag)
        {
            character = other.gameObject.GetComponent<CharacterBase>();
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
