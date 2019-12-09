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
    private int waveCount;
    private bool waveComplete = false;

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
    private void TriggerEndWave()
    {
        if (EndWave != null)
        {
            EndWave();
        }
    }
    //Function : TriggerSpawnWave
    //DESCRIPTION : calls the event when the player when
    //              the StartWave event is triggered. It
    //              instantiates or  sets active enemy units
    //              based on the tier of the enemy
    //PARAMETERS : none
    //RETURNS : none
    private void TriggerSpawnWave()
    {
        if (SpawnWave != null)
        {
            SpawnWave();
        }
    }
}
