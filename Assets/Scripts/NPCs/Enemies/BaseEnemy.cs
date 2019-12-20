using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : BaseNpc
{
    public EnemyObject objectBrain;
    public int accuracy;
    public int quick;
    public int strong;
    private float maxHealth;
    private float currentHealth;
    public int toughness;




    private void Awake()
    {
        getStats();
        setStats();
    }

    private void FixedUpdate()
    {

    }
    public void setStats()
    {
        accuracy = objectBrain.accuracy;
        quick = objectBrain.quick;
        strong = objectBrain.strong;
        toughness = objectBrain.toughness;
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

