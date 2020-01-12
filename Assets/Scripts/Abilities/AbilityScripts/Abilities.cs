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
    protected bool inHotbar = false;
    public virtual void Act() { }
    public virtual void UpdateAbility() { }
    Player player;
    //Function: Abilities()
    //DESCRIPTION: Constructor for base ability script
    //PARAMETERS: none
    //RETURNS: none
    public Abilities()
    {
        SetSprites();
    }
    //Function: UnlockAbility()
    //DESCRIPTION: function used to unlock abilities when player uses a stat point
    //PARAMETERS: none
    //RETURNS: none
    public void UnlockAbility()
    {
        if(player != null && player.playerStatPoints > 0)
        {
            isUnlocked = true;
            player.playerStatPoints = 0;
        }
    }
    //Function: IsUnlocked()
    //DESCRIPTION: function used to return if unlocked or not
    //PARAMETERS: none
    //RETURNS: isUnlocked
    public bool IsUnlocked()
    {
        return isUnlocked;
    }
    //Function: SetPlayer()
    //DESCRIPTION: function used to set the player in constructor for abilities
    //PARAMETERS: Player 
    //RETURNS: None
    public void SetPlayer(Player player)
    {
        this.player = player;
    }
    //Function: SetSprites()
    //DESCRIPTION: function used to set sprites for abilites.
    //PARAMETERS: none
    //RETURNS: None
    public void SetSprites()
    {
        spriteSheetName = "AbilitySpriteSheet";
        sprites = Resources.LoadAll(spriteSheetName, typeof(Sprite));
    }
    //Function: InHotbar()
    //DESCRIPTION: function used check if the ability is in the hotbar already
    //PARAMETERS: none
    //RETURNS: inHotbar
    public bool InHotbar()
    {
        return inHotbar;
    }
    //Function: ToggleIsInHotbar()
    //DESCRIPTION: function used to set abilities into hotbar
    //PARAMETERS: none
    //RETURNS: None
    public void ToggleIsInHOtBar()
    {
        inHotbar = !inHotbar;
    }
}