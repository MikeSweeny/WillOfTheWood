//NAME : HealthStat : Stats
//PURPOSE : The Health Attribute of any Entity
using UnityEngine;

[CreateAssetMenu(menuName = "Attributes/Cunning", fileName = "Cunning")]
public class CunningStat : Stats
{
    private void Awake()
    {
        type = StatType.Cunning;
        name = StatType.Cunning.ToString();
        statValue = 10;

    }
    //FUNCTION : IncreaseStat
    //DESCRIPTION : Increases the Stat (Cunning) on the Entity
    //PARAMETERS : int _value
    //RETURNS : VOID

    public override void IncreaseStat(int _value)
    {
        statValue += _value;
    }
    //FUNCTION : DecreaseStat
    //DESCRIPTION : Decreases the Stat (Cunning) on the Entity
    //PARAMETERS : int _value
    //RETURNS : VOID

    public override void DecreaseStat(int _value)
    {
        statValue -= _value;
    }

    //FUNCTION : ApplyMod
    //DESCRIPTION : Applys a StatModifier to the Stat (this is used in some calculations in skill checks)
    //PARAMETERS : int Value
    //RETURNS : VOID

    public override void ApplyMod(int _value)
    {
        _value = statMod;
        statValue += statMod;

    }
}
