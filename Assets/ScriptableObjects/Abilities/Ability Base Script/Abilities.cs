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
    //Variables that are applied when needed.
    [SerializeField]
    public bool isNovice = false;
    [SerializeField]
    public bool isAdept = false;
    [SerializeField]
    public bool isMaster = false;
    protected bool isCollected = false;

    public virtual void OnLoad() { }
    public virtual void NoviceLevelAct() { }
    public virtual void AdeptLevelAct() { }
    public virtual void MasterLevelAct() { }

    private void OnDestroy()
    {
        isCollected = true;
    }
}