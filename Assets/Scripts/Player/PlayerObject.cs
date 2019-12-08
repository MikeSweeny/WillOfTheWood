
//File Header:
//FILE : PlayerObject.cs
////PROJECT : WillOfTheWood
//PROGRAMMER : Jeff
//FIRST VERSION : 06/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (menuName = "Entity/Player", fileName = "Player")]
public class PlayerObject : EntityObject
{
    public StatSet pStats;

    [Range(0, 100)]
    public int pHealth;
    [Range(0, 20)]
    public int pAccuracy;
    [Range(0, 20)]
    public int pCunning;
    [Range(0, 20)]
    public int pDiscrete;
    [Range(0, 20)]
    public int pPersuasive;
    [Range(0, 20)]
    public int pQuick;
    [Range(0, 20)]
    public int pStrong;
    [Range(0, 20)]
    public int pVigilant;

    //public PlayerController player;
    //Other Player Needed things.

    private void Awake()
    {
        //pHealth = health.statValue;
        //pAccuracy = accuracy.statValue;
        //pCunning = cunning.statValue;
        //pDiscrete = discrete.statValue;
        //pPersuasive = persuasive.statValue;
        //pStrong = strong.statValue;
        //pVigilant = vigilant.statValue;

        GetStats();
    }
    
    public int GetHealth()
    {
        return pHealth;
    }
    public void SetHealth(int _value)
    {
        _value = pHealth;
    }
    public int GetAccuracy()
    {
        return pAccuracy;
    }
    public void SetAccuracy(int _value)
    {
        _value = pAccuracy;
    }
    public int GetCunning()
    {
        return pCunning;
    }
    public void SetCunning(int _value)
    {
        _value = pCunning;
    }
    public int GetDiscrete()
    {
        return pDiscrete;
    }
    public void SetDiscrete(int _value)
    {
        _value = pDiscrete;
    }
    public int GetQuick()
    {
        return pQuick;
    }
    public void SetQuick(int _value)
    {
        _value = pQuick;
    }
    public int GetPersuasive()
    {
        return pPersuasive;
    }
    public void SetPersuasive(int _value)
    {
        _value = pPersuasive;
    }
    public int GetStrong()
    {
        return pStrong;
    }
    public void SetStrong(int _value)
    {
        _value = pStrong;
    }
    public int GetVigilant()
    {
        return pVigilant;
    }
    public void SetVigilant(int _value)
    {
        _value = pVigilant;
    }
    public void GetStats()
    {
        GetHealth();
        GetAccuracy();
        GetCunning();
        GetDiscrete();
        GetPersuasive();
        GetQuick();
        GetStrong();
        GetVigilant();
    }

}
