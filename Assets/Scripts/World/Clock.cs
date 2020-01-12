//FILE : Clock.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Timothy Olenio
//FIRST VERSION : 06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : Clock
//PURPOSE : This class manages the clock and progresses the day
public class Clock
{
    static int currentDay = 1;
    static int hours;
    static float seconds;
    
    //Function : UpdateClock
    //DESCRIPTION : increments seconds at a rate of 24 to 1. Then
    //              progressing hours after an hour's worth of time, 
    //              in-game has passed, and then progress the currentDay
    //              in the same manner. When the day hours expire, it
    //              it calls the GameEventManager to trigger the day and
    //              night
    //PARAMETERS : The difference in time, passed in by the InstanceManager
    //RETURNS : none
    public static void UpdateClock(float deltaTime)
    {
        seconds += 24 * deltaTime;
        //Debug.Log(seconds);

        if (seconds >= 3600)
        {
            hours++;
            seconds = 0;
        }

        if (hours == 16)
        {
            GameEventManager.TriggerStartNight();
        }
        if (hours >= 24)
        {
            GameEventManager.TriggerStartDay();
            hours = 0;
            currentDay++;
        }
    }

    public static float GetTimeOfDay()
    {
        return (hours * 3600) + seconds;
    }

    public static int GetCurrentDay()
    {
        return currentDay;
    }
}
