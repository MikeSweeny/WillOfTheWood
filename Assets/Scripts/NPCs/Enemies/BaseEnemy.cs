using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : BaseNpc
{
    public EnemyObject objectBrain;
    public int vigilant;

    private void Awake()
    {
        getStats();
        setStats();
        currentHealth = maxHealth;
    }

    public void setStats()
    {
        accuracy = objectBrain.accuracy;
        quick = objectBrain.quick;
        strong = objectBrain.strong;
        toughness = objectBrain.toughness;
        vigilant = objectBrain.vigilant;
    }

    //FUNCTION : getStats()
    //DESCRIPTION : Getting the Stats from the objectBrain
    //PARAMETERS : void
    //RETURNS : void
    public void getStats()
    {
        objectBrain.Initialize();
    }

}

