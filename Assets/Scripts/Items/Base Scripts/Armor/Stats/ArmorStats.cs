using UnityEngine;
public class ArmorStats
{
    private int roll;
    protected int minDefence;
    protected int maxDefence;
    public enum armourTypes{LIGHT,MEDIUM,HEAVY};
    public armourTypes armourType;
    //Function : DefenceRoll()
    //DESCRIPTION : checks the armours min and max defence and randomizes a number between them, takes that number and applies it as the roll.
    //PARAMETERS : MinDefence, MaxDefence
    //RETURNS : int roll
    public int DefenceRoll()
    {
        roll = (int)Random.Range(minDefence, maxDefence);
        return roll;
    }
    public int SetMinDefenceStats(int changeMin)
    {
        changeMin = minDefence;
        return changeMin;
    }
    public int SetMaxDefenceStats(int changeMax)
    {
        changeMax = maxDefence;
        return changeMax;
    }
}
