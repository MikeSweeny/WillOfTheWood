//FILE : Clock.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Timothy Olenio
//FIRST VERSION : 06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : Clock
//PURPOSE : This class manages the clock and progresses the day
public class Clock : MonoBehaviour
{
    static int currentDay = 1;
    static int hours;
    static float seconds;

    public static void UpdateClock(float deltaTime)
    {
        seconds += 24 * deltaTime;
        Debug.Log(seconds);

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
}
