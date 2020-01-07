//FILE: CharacterBase.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 19/12/2019
using UnityEngine;

//NAME: CharacterBase
//PURPOSE: the base parent class of all characters, npcs and enemies
public class CharacterBase : MonoBehaviour
{
    protected enum CurrentState
    {
        waiting,
        moving,
        paused,
        attacking,
        dead
    }

    protected int accuracy;
    protected int discrete;
    protected int persuasive;
    protected int quick;
    protected int strong;
    protected int toughness;
    protected int maxHealth;
    protected int currentHealth;
    [Tooltip(" Defense = [Quick –Armor’s Impeding value]")]
    public int defence;
    [Tooltip(" Pain Threshold = Strong/2 (rounded up)")]
    public int painThreshold;
    protected bool isBleeding = false;
    private IArmour armour;
    private IWeapon weapon;
    public GameObject weaponPrefab;
    protected Inventory inventory;

    private void Start()
    {
        armour = null;
        //weapon = GameObject.Instantiate(weaponPrefab.GetComponent<IWeapon>());
        maxHealth = toughness;
        currentHealth = maxHealth;
    }

    private void FixedUpdate()
    {
        CalcToughness();
        CalcPainThreshold();
    }
    //FUNCTION :  CalcToughness()
    //DESCRIPTION : Calcualting the Toughness of the Entity
    //PARAMETERS : void
    //RETURNS : void

    public void CalcToughness()
    {
        if (toughness <= 9)
        {
            toughness = 10;
        }
        if (strong >= 10)
        {
            toughness = strong;
        }
    }
    //FUNCTION : CalcPainThreshold()
    //DESCRIPTION : Calculating the Pain Threshold of the Entity
    //PARAMETERS : void
    //RETURNS : void

    public void CalcPainThreshold()
    {
        painThreshold = strong / 2;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    //Function: GetHealthPercent
    //DESCRIPTION: function used to find the current health percent
    //PARAMETERS: None
    //RETURNS: float
    public float GetHealthPercent()
    {
        return (float)maxHealth / (float)currentHealth;
    }
}
