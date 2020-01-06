using UnityEngine;
public class ArmorStats
{
    private int roll;
    protected int minDefence;
    protected int maxDefence;

    //Function : DefenceRoll()
    //DESCRIPTION : checks the armours min and max defence and randomizes a number between them, takes that number and applies it as the roll.
    //PARAMETERS : MinDefence, MaxDefence
    //RETURNS : int roll
    public int DefenceRoll()
    {
        roll = (int)Random.Range(minDefence, maxDefence);
        return roll;
    }
}
