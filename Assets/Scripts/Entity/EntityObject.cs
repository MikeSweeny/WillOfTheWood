using UnityEngine;
//File Header: EntityObject
//FILE : EntityObject.cs
//PROJECT : WillOfTheWood
//PROGRAMMER : Jeff Oldfield    
//FIRST VERSION : 06/12/2019

//Class Header:
//NAME : EnttiyObject : ScriptableObject
//PURPOSE : To setup and initialize base Game Entities like the Player, Enemies and NPCs

public enum EntityType
{
    Player,
    Enemy,
    NPC,
    Other
}
//Class Header:
//NAME : EnttiyObject : ScriptableObject
//PURPOSE : Building Entities to be used i nthe game world with default perameters set.

public abstract class EntityObject : ScriptableObject
{
    public  new string name;
    public int ID;
    [TextArea(10, 10)]
    public string description;
    public EntityType type;

}

//Class Header:
//NAME : Entiy
//PURPOSE : To setup and initialize base Game Entities like the Player, Enemies and NPCs

public class Entity
{
    public string name;
    public int ID;
    public EntityType type;

    //Function Header:
    //FUNCTION : Entitiy()
    //DESCRIPTION : Initialize child Classes with the information set in the Entity : ScriptableObjects class
    //PARAMETERS : EntityObject entity
    //RETURNS : VOID

    public Entity(EntityObject entity)
    {
        name = entity.name;
        ID = entity.ID;
        type = entity.type;
    }
   
}
