﻿using UnityEngine;

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

    public int accuracy;
    public int discrete;
    public int persuasive;
    public int quick;
    public int strong;
    public int toughness;
    public int maxHealth;
    protected int currentHealth;
    [Tooltip(" Defense = [Quick –Armor’s Impeding value]")]
    public int defence;
    [Tooltip(" Pain Threshold = Strong/2 (rounded up)")]
    public int painThreshold;
    protected bool isBleeding = false;
    private IArmour armour;
    private void Start()
    {
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
}
