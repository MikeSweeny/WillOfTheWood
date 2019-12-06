
//File Header:
//FILE : EnemyObject.cs
////PROJECT : WillOfTheWood
//PROGRAMMER : Jeff
//FIRST VERSION : 06/12/2019

//Class Header:
//NAME : EnemyObject : EntityObject
//PURPOSE : To setup and initialize base Game Entities like the Player, Enemies and NPCs
using UnityEngine;
[CreateAssetMenu(menuName = "Entity/Enemy", fileName = "Entities")]
public class EnemyObject : EntityObject
{
    // Uncomment when we have the Stats Setup in game

    //public Stats health;
    //public Stats accuracy;
    //public Stats cunning;
    //public Stats discrete;
    //public Stats persuasive;
    //public Stats quick;
    //public Stats strong;
    //public Stats vigilant;

    public int eHealth;
    public int eAccuracy;
    public int eCunning;
    public int eDiscrete;
    public int ePersuasive;
    public int eQuick;
    public int eStrong;
    public int eVigilant;

////FUNCTION : Awake()
////DESCRIPTION : Sets the EnemyObjects Stats to the Default BaseStats
////PARAMETERS : VOID
////RETURNS : VOID 

    private void Awake()
    {
        //eHealth = health.statValue;
        //eAccuracy = accuracy.statValue;
        //eCunning = cunning.statValue;
        //eDiscrete = discrete.statValue;
        //ePersuasive = persuasive.statValue;
        //eStrong = strong.statValue;
        //eVigilant = vigilant.statValue;

        GetStats();

    }
    //FUNCTION : GetHealth
    //DESCRIPTION :Gets the enemies eHealth
    //PARAMETERS : VOID
    //RETURNS : eHealth
    public int GetHealth()
    {
        return eHealth;
    }

    //FUNCTION : SetHealth
    //DESCRIPTION : Sets the enemies eHealth
    //PARAMETERS : int _value
    //RETURNS : Void
    public void SetHealth(int _value)
    {
        _value = eHealth;
    }

    //FUNCTION : GetAccuracy
    //DESCRIPTION :Sets the enemies eAccuracy
    //PARAMETERS : VOID
    //RETURNS : eAccuracy
    public int GetAccuracy()
    {
        return eAccuracy;
    }

    //FUNCTION : SetAccuracy
    //DESCRIPTION :Sets the enemies eAccuracy
    //PARAMETERS : int _value
    //RETURNS : VOID
    public void SetAccuracy(int _value)
    {
        _value = eAccuracy;
    }

    //FUNCTION : GetCunning
    //DESCRIPTION :Gets the enemies eCunning
    //PARAMETERS : VOID
    //RETURNS : eCunning
    public int GetCunning()
    {
        return eCunning;
    }
    //FUNCTION : SetCunning
    //DESCRIPTION :Gets the enemies eCunning
    //PARAMETERS : int _value
    //RETURNS : VOID
    public void SetCunning(int _value)
    {
        _value = eCunning;
    }


    //FUNCTION : GetDiscrete
    //DESCRIPTION :Gets the enemies eDiscrete
    //PARAMETERS : VOID
    //RETURNS : eDiscrete
    public int GetDiscrete()
    {
        return eDiscrete;
    }
    //FUNCTION : SetDiscrete
    //DESCRIPTION :Gets the enemies eDiscrete
    //PARAMETERS : int _value
    //RETURNS : VOID
    public void SetDiscrete(int _value)
    {
        _value = eDiscrete;
    }


    //FUNCTION : GetQuick
    //DESCRIPTION :Gets the enemies eQuick
    //PARAMETERS : VOID
    //RETURNS : eQuick
    public int GetQuick()
    {
        return eQuick;
    }

    //FUNCTION : SetQuick
    //DESCRIPTION : Sets the enemies eQuick
    //PARAMETERS : int _value
    //RETURNS : VOID
    public void SetQuick(int _value)
    {
        _value = eQuick;
    }

    //FUNCTION : GetPersuasive
    //DESCRIPTION :Gets the enemies ePersuasive
    //PARAMETERS : VOID
    //RETURNS : ePersuasive
    public int GetPersuasive()
    {
        return ePersuasive;
    }


    //FUNCTION : SetPersuasive
    //DESCRIPTION : Sets the enemies ePersuasive
    //PARAMETERS : int _value
    //RETURNS : VOID
    public void SetPersuasive(int _value)
    {
        _value = ePersuasive;
    }


    //FUNCTION : GetStrong
    //DESCRIPTION :Gets the enemies eStrong
    //PARAMETERS : VOID
    //RETURNS : eStrong
    public int GetStrong()
    {
        return eStrong;
    }


    //FUNCTION : SetStrong
    //DESCRIPTION : Sets the enemies eStrong
    //PARAMETERS : int _value
    //RETURNS : VOID

    public void SetStrong(int _value)
    {
        _value = eStrong;
    }


    //FUNCTION : GetVigilant
    //DESCRIPTION :Gets the enemies eVigilant
    //PARAMETERS : VOID
    //RETURNS : eVigilant
    public int GetVigilant()
    {
        return eVigilant;
    }


    //FUNCTION : SetVigilant
    //DESCRIPTION :Gets the enemies eVigilant
    //PARAMETERS : int _value
    //RETURNS : VOID
    public void SetVigilant(int _value)
    {
        _value = eVigilant;
    }


    //FUNCTION : GetStats
    //DESCRIPTION : Function to get all of the enemies stats
    //PARAMETERS : VOID
    //RETURNS : VOID
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
