//FILE : Ability.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Jonathan Parsons
//FIRST VERSION : 16/12/2019
using UnityEngine;

//NAME : Abilities Base Scriptable Object
//PURPOSE :Parent used to create the abilities

//Puts 'Ability' into the asset menu to be called in unity
public class Abilities
{
    //Sets the name and description of ability
    public string abilityName;
    public string abilityDescription;
    public string spriteSheetName;
    protected Object[] sprites;
    public Sprite abilityImage{ get; set; }
    protected bool isUnlocked = false;
    public virtual void Act() { }
    public virtual void UpdateAbility() { }
    Player player;

    public Abilities()
    {
        //SetSprites();
    }
    public void UnlockAbility()
    {
        if(player.playerStatPoints > 0)
        {
            isUnlocked = true;
        }
    }
    public bool IsUnlocked()
    {
        return isUnlocked;
    }
    public void SetPlayer(Player player)
    {
        this.player = player;
    }
    public void SetSprites()
    {
        spriteSheetName = "AbilitySpriteSheet";
        sprites = Resources.LoadAll(spriteSheetName, typeof(Sprite));
    }
}