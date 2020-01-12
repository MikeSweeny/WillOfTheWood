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
    protected int speed;
    protected int strong;
    protected int toughness;
    protected int maxHealth;
    public int currentHealth;
    [Tooltip(" Defense = Quick")]
    public int defence;
    [Tooltip(" Pain Threshold = Strong/2 (rounded up)")]
    public int painThreshold;
    protected bool isBleeding = false;
    private IArmour armour;
    private IWeapon weapon;
    public GameObject weaponPrefab;

    protected Inventory inventory;
    public string CharacterName;

    private void Start()
    {
        armour = null;
        maxHealth = toughness;
        currentHealth = maxHealth;
    }

    //Function : EquippedArmour() 
    //DESCRIPTION : Function to equip armour to this entity
    //PARAMETERS : none
    //RETURNS : none
    public void EquipArmour(IArmour item)
    {
        item = armour;
    }
    //Function : EquippedWeapon() 
    //DESCRIPTION : Function to equip weapon to this entity
    //PARAMETERS : none
    //RETURNS : none
    public void EquipWeapon(IWeapon item)
    {
        item = weapon;
    }
    //Function : CalcToughness() 
    //DESCRIPTION : Function to calulate toughness of this entity
    //PARAMETERS : none
    //RETURNS : none
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
    //Function : TakeDamage()
    //DESCRIPTION : Function that applies damage.
    //PARAMETERS : Int Damage
    //RETURNS : none
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    //Function: GetHealthPercent()
    //DESCRIPTION: function used to find the current health percent
    //PARAMETERS: None
    //RETURNS: float
    public float GetHealthPercent()
    {
        return (float)currentHealth / (float)maxHealth;
    }
    //Function : RecoverHealth()
    //DESCRIPTION : Function to call for when gaining health
    //PARAMETERS : none
    //RETURNS : none
    public void RecoverHealth()
    {
        if(currentHealth != maxHealth)
        {
            int heal;
            heal = Random.Range(1, 4);
            currentHealth = currentHealth + heal;
        }
    }
    //Function: SetDefence()
    //DESCRIPTION: function used to Set the Defence of the object
    //PARAMETERS: None
    //RETURNS: none
    public void SetDefence()
    {
        defence = speed;
    }
    //Function : SetArmour() 
    //DESCRIPTION : Functions to set players armour
    //PARAMETERS : IArmour armour
    //RETURNS : none
    public void SetArmour(IArmour armour)
    {
        this.armour = armour;
    }

}
