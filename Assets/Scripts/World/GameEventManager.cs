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
    public static event GameEvent Restart;
    public static event GameEvent StartDay;
    public static event GameEvent StartNight;

    //Function : TriggerGameStart
    //DESCRIPTION : calls the event to start the game
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerGameStart()
    {
        if (GameStart != null)
            GameStart();
    }

    //Function : TriggerGameOver
    //DESCRIPTION : calls the event when the player dies
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerGameOver()
    {
        if (GameOver != null)
            GameOver();
    }

    //Function : TriggerPause
    //DESCRIPTION : calls the event that pauses the game
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerPause()
    {
        if (Pause != null)
            Pause();
    }

    //Function : TriggerUnpause
    //DESCRIPTION : calls the event to unpause the game
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerUnPause()
    {
        if (UnPause != null)
            UnPause();
    }

    //Function : TriggerRestart
    //DESCRIPTION : calls the event that restarts the game
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerRestart()
    {
        if (Restart != null)
            Restart();
    }

    //Function : TriggerStartDay
    //DESCRIPTION : call the event that starts a new day
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerStartDay()
    {
        if (StartDay != null)
            StartDay();
    }

    //Function : TriggerStartNight
    //DESCRIPTION : call the event that starts the night
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerStartNight()
    {
        if (StartNight != null)
            StartNight();
    }
}
