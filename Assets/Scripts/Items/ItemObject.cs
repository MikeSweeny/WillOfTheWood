//FILE : ItemObject.cs
//PROJECT : WillOfTheWood
//PROGRAMMER : Jeff Oldfield    
//FIRST VERSION : 07/12/2019

using UnityEngine;
public enum ItemType
{
    Armour,
    Weapon,
    Consumable,
    Gold,
    Other
}
//Class Header:
////NAME : ItemObject : ScriptableObject
////PURPOSE : Creates Items as a ScriptableObject in Unity, allowing us to create as many Items as we need
public abstract class ItemObject : ScriptableObject
{
    public int ID;
    public new string name;
    public Sprite uiDisplay;
    public ItemType type;
    public bool isStackable;
    [TextArea(15, 20)]
    public string description;

    public virtual void UseItem() { }
}
//Class Header:
////NAME : item
////PURPOSE : Creating multiple Items with initial values;
[System.Serializable]
public class item
{
    public string name;
    public int ID;
    private bool isStackable;
    public item(ItemObject item)
    {
        isStackable = item.isStackable;
        name = item.name;
        ID = item.ID;
    }


}
