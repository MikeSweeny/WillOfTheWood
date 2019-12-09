//FILE : WaveManager.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Timothy Olenio
//FIRST VERSION : 09/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : WaveManager
//PURPOSE : This class manages the waves of enemies
//on the final day during the final battle. Managing
//When waves begin, end and what they are comprised of
public class WaveManager
{
    public static int enemyCount;

    public delegate void WaveEvent();
    public static event WaveEvent StartWave;
    public static event WaveEvent EndWave;
    public static event WaveEvent SpawnWave;
    
    //Function : TriggerStartWave
    //DESCRIPTION : calls the event when the final battle
    //              begins and after EndWave
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerStartWave()
    {
        if (StartWave != null)
        {
            StartWave();
        }
    }
    //Function : TriggerStartWave
    //DESCRIPTION : calls the event when the player kills
    //              all the enimies in a wave of enemies
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerEndWave()
    {
        if (EndWave != null)
        {
            EndWave();
        }
    }
}
