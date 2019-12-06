//FILE : GameEventManager.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Gavin McGuire
//FIRST VERSION : 06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : GameEventManager
//PURPOSE : This class manages any major game events
// all the methods and attributes are static as to 
// remove the need to instantiate the class
public class GameEventManager
{
    public delegate void GameEvent();

    public static event GameEvent GameStart;
    public static event GameEvent GameOver;
    public static event GameEvent Pause;
    public static event GameEvent UnPause;
    public static event GameEvent StartDay;
    public static event GameEvent StartNight;

    public static void TriggerGameStart()
    {
        if (GameStart != null)
            GameStart();
    }

    public static void TriggerGameOver()
    {
        if (GameOver != null)
            GameOver();
    }

    public static void TriggerPause()
    {
        if (Pause != null)
            Pause();
    }

    public static void TriggerUnPause()
    {
        if (UnPause != null)
            UnPause();
    }

    public static void TriggerStartDay()
    {
        if (StartDay != null)
            StartDay();
    }

    public static void TriggerStartNight()
    {
        if (StartNight != null)
            StartNight();
    }
}
