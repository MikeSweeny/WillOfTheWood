
//File Header:
//FILE : EnenmyObject.cs
////PROJECT : WillOfTheWood
//PROGRAMMER : Jeff
//FIRST VERSION : 06/12/2019

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
    //FUNCTION : GetHealth/GetAccuracy/GetCunning/GetDiscrete/GetPersuasive/GetQuick/GetStrong/GetVigilant
    //DESCRIPTION :Gets the enemies Called Stat
    //PARAMETERS : VOID
    //RETURNS : eHealth, eAccuracy, eCunning, eDiscrete, ePersuasive, eQuick, eStrong, eVigilant
    public int GetHealth()
    {
        return eHealth;
    }

    //FUNCTION : SetHealth/SetAccuracy/SetCunning/SetDiscrete/SetPersuasive/SetQuick/SetStrong/SetVigilant
    //DESCRIPTION : Setting the Stat to the Value we put in.
    //PARAMETERS : int _value
    //RETURNS : 

    public void SetHealth(int _value)
    {
        _value = eHealth;
    }
    public int GetAccuracy()
    {
        return eAccuracy;
    }
    public void SetAccuracy(int _value)
    {
        _value = eAccuracy;
    }
    public int GetCunning()
    {
        return eCunning;
    }
    public void SetCunning(int _value)
    {
        _value = eCunning;
    }
    public int GetDiscrete()
    {
        return eDiscrete;
    }
    public void SetDiscrete(int _value)
    {
        _value = eDiscrete;
    }
    public int GetQuick()
    {
        return eQuick;
    }
    public void SetQuick(int _value)
    {
        _value = eQuick;
    }
    public int GetPersuasive()
    {
        return ePersuasive;
    }
    public void SetPersuasive(int _value)
    {
        _value = ePersuasive;
    }
    public int GetStrong()
    {
        return eStrong;
    }
    public void SetStrong(int _value)
    {
        _value = eStrong;
    }
    public int GetVigilant()
    {
        return eVigilant;
    }
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
