//FILE : Ability.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Jonathan Parsons
//FIRST VERSION : 16/12/2019
using UnityEngine;

//NAME : Abilities Base Scriptable Object
//PURPOSE :Parent used to create the abilities

//Puts 'Ability' into the asset menu to be called in unity
public class Abilities: ScriptableObject
{
    //Sets the name and description of ability
    [SerializeField]
    private string abilityName;
    [SerializeField]
    [TextArea(10, 10)]
    private string abilityDescription;
    [SerializeField]
    private Sprite abilityImage;
    protected bool isUnlocked = false;
    public virtual void OnLoad() { }
    public virtual void Act() { }
    public virtual void UpdateAbility() { }
    public void UnlockAbility()
    {
        isUnlocked = true;
    }
    public bool IsUnlocked()
    {
        return isUnlocked;
    }
}