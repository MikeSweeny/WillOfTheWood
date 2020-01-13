//FILE: Player.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts, Jeff Oldfield
//FIRST VERSION: 17/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//NAME: Player
//PURPOSE: the player class, used to track stats and abilities that the player has
public class Player : CharacterBase
{
    public PlayerStats playerBrain;

    private List<Abilities> abilities;
    private bool canShootTargetRay = false;
    private bool firstUpdate = true;
    private GameObject target;
    private Vector3 midRayFiringPoint;
    private Vector3 bottomRayFiringPoint;
    private float expCap;
    private float currentEXP;
    private int playerCoins;
    public int playerStatPoints { get; set; }
    private float healthPerc;
    protected int unlockedAbilityCount;
    private List<HotbarSlot> hotbar;
    private const int hotbarSlots = 8;
    //FUNCTION : Awake()
    //DESCRIPTION : Sets Variables and functions on awake.
    //PARAMETERS : none
    //RETURNS : none 
    private void Awake()
    {
        playerStatPoints = 1;
        hotbar = new List<HotbarSlot>();
        for (int i = 0; i < hotbarSlots; i++)
        {
            hotbar.Add(new HotbarSlot());
        }
        abilities = new List<Abilities>();
        abilities.Add(new AtArms());
        abilities.Add(new Backstab());
        abilities.Add(new Berserker());
        abilities.Add(new Dominate());
        abilities.Add(new ExceptionalAttribute());
        abilities.Add(new Feign());
        abilities.Add(new Poisoner());
        abilities.Add(new PolearmMastery());
        abilities.Add(new Recovery());
        abilities.Add(new ShieldFighter());
        abilities.Add(new TwoHandedForce());

        for (int i = 0; i < abilities.Count; i++)
        {
            abilities[i].SetPlayer(this);
        }

        AbilityManager.UnlockAtArms += UpdateHotbar;
        AbilityManager.UnlockBackStab += UpdateHotbar;
        AbilityManager.UnlockBerserker += UpdateHotbar;
        AbilityManager.UnlockDominate += UpdateHotbar;
        AbilityManager.UnlockExceptionalAttribute += UpdateHotbar;
        AbilityManager.UnlockFeign += UpdateHotbar;
        AbilityManager.UnlockPoisoner += UpdateHotbar;
        AbilityManager.UnlockPoleArmMastery += UpdateHotbar;
        AbilityManager.UnlockRecovery += UpdateHotbar;
        AbilityManager.UnlockShieldFighter += UpdateHotbar;
        AbilityManager.UnlockTwinAttack += UpdateHotbar;
        AbilityManager.UnlockTwoHandedForce += UpdateHotbar;
        //getStats();
        setStats();

        //Debug.Log("Stats" + " accuracy : " + accuracy + " discrete : " + discrete + " persuasive : " + persuasive + " quick : " + speed + " strong : " + strong);
        //Debug.Log("Stats" + " toughness : " + toughness + " maxHealth : " + maxHealth + " currentHealth : " + currentHealth + " currentEXP : " + currentEXP);
        //Debug.Log("Defence : " + defence);
        expCap = 200f;
        currentEXP = 0;
        playerCoins = 0;
 
    }
    //FUNCTION : Update()
    //DESCRIPTION : Updates every frame with player logic
    //PARAMETERS : none
    //RETURNS : none 
    private void Update()
    {
        if(firstUpdate)
        {
            inventory = new IPlayerInventory();
            firstUpdate = false;
        }
        if (canShootTargetRay == true)
        {
            canShootTargetRay = false;
            FindPlayerTarget();
        }
        else
        {
            canShootTargetRay = true;
        }
        healthPerc = GetHealthPercent();
        //Debug.Log("Health Perc : " + healthPerc);

        if (currentHealth < 0)
        {
            currentHealth = 0;
            SceneManager.LoadScene("DeathScene");
        }

        midRayFiringPoint = new Vector3(transform.position.x, (transform.position.y + 1), transform.position.z);
        bottomRayFiringPoint = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
    }

    //FUNCTION : setStats()
    //DESCRIPTION : Seting the stats from the StatsSet onto the player
    //PARAMETERS : types and names
    //RETURNS : type and use 
    public void setStats()
    {
        currentHealth = maxHealth;
        accuracy = playerBrain.accuracy;
        discrete = playerBrain.discrete;
        persuasive = playerBrain.pursuasive;
        speed = playerBrain.speed;
        strong = playerBrain.strong;
        CalcToughness();
        CalcPainThreshold();
        SetMaxHealth();
        SetDefence();
    }


    //Function: FindPlayerTarget
    //DESCRIPTION: finds the target in front of the player if there is one
    //PARAMETERS: RaycastHit hit
    //RETURNS: hit.collider.gameObject, null
    public GameObject FindPlayerTarget()
    {
        RaycastHit hit;

        if ((Physics.Raycast(midRayFiringPoint, transform.forward, out hit, 8) || Physics.Raycast(bottomRayFiringPoint, transform.forward, out hit, 8)) && hit.transform.tag != "FaceCam")
        {
            if(hit.collider.gameObject != this.gameObject)
                target = hit.collider.gameObject;
            return target;
        } 
        else
        {
            target = null;
        }
        return target;
    }

    //Function: GetPlayerTarget
    //DESCRIPTION: returns the players target for use in outside functions
    //PARAMETERS: None
    //RETURNS: GameObject target
    public GameObject GetPlayerTarget()
    {
        return target;
    }

    //Function: GetXPPercent
    //DESCRIPTION: function used to get the current percent of xp bar filled
    //PARAMETERS: None
    //RETURNS: float
    public float GetXPPercent()
    {
        return currentEXP / expCap;
    }

    //Function: AddXP
    //DESCRIPTION: this function will be used to add xp to the player
    //PARAMETERS: int amount
    //RETURNS: None
    public void AddXP(int amount)
    {
        if(currentEXP < expCap)
        {
            currentEXP += (float)amount;
        }
        else if(currentEXP >= expCap)
        {
            currentEXP = expCap;
        }
    }

    //Function: GetPlayerCoins
    //DESCRIPTION: function used to get the player coins
    //PARAMETERS: None
    //RETURNS: float playerCoins
    public int GetPlayerCoins()
    {
        return playerCoins;
    }

    //Function: SubtractCoins
    //DESCRIPTION: function used to spend / remove coins
    //PARAMETERS: int amount
    //RETURNS: None
    public void SubtractCoins(int amount)
    {
        playerCoins -= amount;
    }

    //Function: AddCoins(int amount)
    //DESCRIPTION: function used to add / recieve coins
    //PARAMETERS: int amount
    //RETURNS: None
    public void AddCoins(int amount)
    {
        playerCoins += amount;
    }
    //Function: AddStatPoint()
    //DESCRIPTION: function used to add / recieve Stat Points
    //PARAMETERS: int amount
    //RETURNS: None
    public void AddStatPoint(int addPoint)
    {
        playerStatPoints += addPoint;
    }
    //Function: UsedStatPoint()
    //DESCRIPTION: function used to remove stat points
    //PARAMETERS: int amount
    //RETURNS: None
    public void UsedStatPoint()
    {
        playerStatPoints--;
    }
    //Function: GetStatPoint()
    //DESCRIPTION: checks playerStatPoints
    //PARAMETERS: none
    //RETURNS: playerStatPoints
    public int GetStatPoints()
    {
        return playerStatPoints;
    }
    //Function: SetMaxHealth()
    //DESCRIPTION: Setting maxHealth variable at start of game, and when maxHealth is increased
    //PARAMETERS: void
    //RETURNS: maxHealth
    public int SetMaxHealth()
    {
        maxHealth = toughness;
        return maxHealth;
    }
    //Function: UpdateHotBar()
    //DESCRIPTION: function used to update the hotbar with abilities unlocked.
    //PARAMETERS: none
    //RETURNS: none
    public void UpdateHotbar()
    {
        unlockedAbilityCount++;
        for (int i = 0; i < unlockedAbilityCount; i++)
        {
            foreach (Abilities ability in abilities)
            {
                if (ability.IsUnlocked() && !ability.InHotbar())
                {
                    for (int n = 0; n < hotbar.Count; ++n)
                    {
                        if (hotbar[n].ability == null)
                        {
                            hotbar[n].ability = ability;
                            ability.ToggleIsInHOtBar();
                            break;
                        }
                    }
                }
            }
        }
    }
    //Function: GetHotbar()
    //DESCRIPTION: function used to return hotbar
    //PARAMETERS: none
    //RETURNS: hotBar
    public List<HotbarSlot> GetHotbar()
    {
        return hotbar;
    }
}
