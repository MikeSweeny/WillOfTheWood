//FILE          :   ExceptionalAttribute.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   31/12/2019
using UnityEngine;
//NAME : ExceptionalAttribute
//PURPOSE : All the funcionality of the ExceptionalAttribute ability as a child of abilities
public class ExceptionalAttribute : Abilities
{
    private PlayerStats player;
    private UExceptionalAttributeButton button;
    private int choice = 6;
    private bool isChoosing = false;
    private bool isActive { get; set; }
    //Function :  : base() constructor 
    //DESCRIPTION : Constructor that sets the name,description, image, and unlocks the ability function
    //PARAMETERS : none
    //RETURNS : none
    public ExceptionalAttribute() : base()
    {
        abilityName = "ExceptionalAttribute";
        abilityDescription = "Add 1 point to any stat.";
        abilityImage = (Sprite)sprites[156];
        AbilityManager.UnlockExceptionalAttribute += UnlockAbility;
    }
    //Function: UpdateAbility()
    //DESCRIPTION: Override function for the UpdateAbility() function in base class
    //PARAMETERS: none
    //RETURNS: None
    public override void UpdateAbility()
    {
        if (isActive)
        {
            Act();
        }
    }
    //Function : Act()
    //DESCRIPTION : Override function for the act() base function
    //PARAMETERS : none
    //RETURNS : none
    public override void Act()
    {
        if (isActive)
        {
            isChoosing = true;
            if(isChoosing)
            {
                switch (choice)
                {
                    case 6:
                        player.IncreaseStat(1, player.accuracy);
                        isChoosing = false;
                        break;
                    case 5:
                        player.IncreaseStat(1, player.discrete);
                        isChoosing = false;
                        break;
                    case 4:
                        player.IncreaseStat(1, player.pursuasive);
                        isChoosing = false;
                        break;
                    case 3:
                        player.IncreaseStat(1, player.speed);
                        isChoosing = false;
                        break;
                    case 2:
                        player.IncreaseStat(1, player.strong);
                        isChoosing = false;
                        break;
                    case 1:
                        player.IncreaseStat(1, player.defence);
                        isChoosing = false;
                        break;
                }
            } 
        }
        //button.gameObject.SetActive(false);
    }
}
