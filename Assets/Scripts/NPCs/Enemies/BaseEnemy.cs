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
        
    }

    private void FixedUpdate()
    {

    }

}

