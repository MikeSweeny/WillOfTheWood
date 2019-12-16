//FILE : Ability.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Jonathan Parsons
//FIRST VERSION : 16/12/2019
using UnityEngine;

//NAME : Ability Base Scriptable Object
//PURPOSE :Creates abilities and sets the base perameters needed to apply different effects on the player.
[CreateAssetMenu(fileName = "NewAbility", menuName = "Ability", order = 51)]
public class Ability : ScriptableObject
{
    [SerializeField]
    private string abilityName;
    [SerializeField]
    private string abilityDescription;   
}