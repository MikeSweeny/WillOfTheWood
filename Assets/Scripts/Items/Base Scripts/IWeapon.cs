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
    public bool isPoisonous = false;
    Collider collider;
    private int defModValue;
    private int defValue;
    private int accValue;

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    public void Awake()
    {
        itemType = ItemTypes.WEAPON;
        itemSprite = GetComponent<Image>();
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

    public WeaponStats GetStats()
    {
        return stats;
    }
    //Function : OnTriggerEnter
    //DESCRIPTION : checks the collider for the object being hit and applies damage to that object
    //PARAMETERS : none
    //RETURNS :none
    public void OnTriggerEnter(Collider other)
    {
        CharacterBase character = other.gameObject.GetComponent<CharacterBase>();

        defValue = other.gameObject.GetComponent<CharacterBase>().defence;

        if (other.gameObject.transform.root.tag != gameObject.transform.root.tag)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                defValue = other.gameObject.GetComponent<CharacterBase>().defence;

                accValue = gameObject.GetComponentInParent<Player>().playerBrain.accuracy;
                Debug.Log("Attacker(Player) Accuracy : " + accValue);
                Debug.Log("Roll at start: " + roll);
                roll = D20Roll();
                Debug.Log("After Roll : " + roll);
                Debug.Log("DefModValue : " + defModValue);
                defModValue = AbilityModifier(defValue);
                Debug.Log("DefModValue : " + defModValue + "defValue : " + defValue);
                Debug.Log("Roll : " + roll + " defModValue : " + defModValue);
                ApplyMod(roll, defModValue);
                Debug.Log("Final Roll : " + roll);
                Debug.Log(roll + " " + " </> " + accValue);
                if (roll < accValue)
                {
                    gameObject.GetComponent<Collider>().isTrigger = false;
                    character.TakeDamage(AttackRoll());
                }
            }

            else if (other.gameObject.CompareTag("Player"))
            {
                defValue = other.gameObject.GetComponent<CharacterBase>().defence;

                accValue = gameObject.GetComponentInParent<BaseEnemy>().npcStats.Accuracy;
                Debug.Log("Attacker(Enemy) Accuracy : " + accValue);
                Debug.Log("Roll at start: " + roll);
                roll = D20Roll();
                Debug.Log("After Roll : " + roll);
                Debug.Log("DefModValue : " + defModValue);
                defModValue = AbilityModifier(defValue);
                Debug.Log("DefModValue : " + defModValue + "defValue : " + defValue);
                Debug.Log("Roll : " + roll + " defModValue : " + defModValue);
                ApplyMod(roll, defModValue);
                Debug.Log("Final Roll : " + roll);
                Debug.Log(roll + " " + " </> " + accValue);
                if (roll < accValue)
                {
                    gameObject.GetComponent<Collider>().isTrigger = false;
                    character.TakeDamage(AttackRoll());
                }
            }
            else
            {
                Debug.Log("Nothng");
            }
        }
    }
    //Function : AttackRoll
    //DESCRIPTION : checks the weapons min and max damage and randomizes a number between them, takes that number and applies it as the roll.
    //PARAMETERS : attackMinDamage, attackMaxDamage
    //RETURNS : int roll
    public int AttackRoll()
    {
        roll = (int)Random.Range(stats.GetAttackMinDamage(), stats.GetAttackMaxDamage());
        return roll;
    }
    public void AddPoisonDamageModifier()
    {
        stats.SetAttackMinDamageModifier(1);
        stats.SetAttackMinDamageModifier(4);
    }
    private int D20Roll()
    {
        int roll = Random.Range(1, 20);
        return roll;
    }

    int ApplyMod(int roll, int defModValue)
    {
        roll += defModValue;
        return roll;
    }

    int AbilityModifier(int defTempValue)
    {
        if (defTempValue == 5) { defModValue = 5; }
        else if (defTempValue == 6) { defModValue = 4; }
        else if (defTempValue == 7) { defModValue = 3; }
        else if (defTempValue == 8) { defModValue = 2; }
        else if (defTempValue == 9) { defModValue = 1; }
        else if (defTempValue == 10) { defModValue = 0; }
        else if (defTempValue == 11) { defModValue = -1; }
        else if (defTempValue == 11) { defModValue = -2; }
        else if (defTempValue == 13) { defModValue = -3; }
        else if (defTempValue == 14) { defModValue = -4; }
        else if (defTempValue == 15) { defModValue = -5; }

        return defModValue;
    }
}
    

