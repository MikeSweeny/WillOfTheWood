//FILE : Ability.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Jonathan Parsons
//FIRST VERSION : 16/12/2019
using UnityEngine;

//NAME : Ability Base Scriptable Object
//PURPOSE :Creates abilities and sets the base perameters needed to apply different effects on the player.

//Puts 'Ability' into the asset menu to be called in unity
[CreateAssetMenu(fileName = "NewAbility", menuName = "Ability", order = 51)]
public class Ability : ScriptableObject
{
    //Sets the name and description of ability
    [SerializeField]
    private string abilityName;
    [SerializeField]
    [TextArea(10, 10)]
    private string abilityDescriptionNoviceLevel;
    [SerializeField]
    [TextArea(10, 10)]
    private string abilityDescriptionAdaptLevel;
    [SerializeField]
    [TextArea(10, 10)]
    private string abilityDescriptionMasterLevel;
    //Variables that are applied when needed.
    [SerializeField]
    private Sprite abilityImage;
    [SerializeField]
    private int damageModifier;
    [SerializeField]
    private int speedModifier;
    [SerializeField]
    private int persuasionModifier;
    [SerializeField]
    private int strengthModifier;
    [SerializeField]
    private int detectionModifier;

    public virtual void noviceLevel() { }
    public virtual void adeptLevel() { }
    public virtual void masterLevel() { }
}