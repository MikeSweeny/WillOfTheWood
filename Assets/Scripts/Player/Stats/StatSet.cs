using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Stats/Statsets", fileName = "Primary Stats")]
public class StatSet : StatsObject
{
    public int accuracy;
    public int discrete;
    public int pursuasive;
    public int quick;
    public int strong;
    public int vigilant;


    private void Awake()
    {
        accuracy = Accuracy;
        discrete = Discrete;
        pursuasive = Pursuasive;
        quick = Quick;
        strong = Strong;
        vigilant = Vigilant;
    }

    public override void IncreaseStat(int _value, int _secondValue)
    {
        _value += _secondValue;
    }
}
