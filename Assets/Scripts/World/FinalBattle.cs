//FILE          :   FinalBattle.cs
//PROJECT       :   Will of the Woods
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   09/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : FinalBattle
//PURPOSE : Handles mechanics for the game's climactic fight
public class FinalBattle : MonoBehaviour
{
    private bool startOfWave;
    private float interludeDuration;
    private float interludeTime;
    private bool betweenWaves;

    //Function : Awake
    //DESCRIPTION : Initializes the gameobject
    //PARAMETERS : none
    //RETURNS : none
    private void Awake()
    {
        betweenWaves = true;
        interludeDuration = 10.0f;
        interludeTime = 0.0f;
        startOfWave = false;
        WaveManager.StartWave += StartWave;
        WaveManager.EndWave += EndWave;
    }

    //Function : Update
    //DESCRIPTION : updates the gameobject
    //PARAMETERS : none
    //RETURNS : none
    private void Update()
    {
        if (betweenWaves)
        {
            if (interludeTime >= interludeDuration)
            {
                WaveManager.TriggerStartWave();
            }
            else
            {
                interludeTime += Time.deltaTime;
            }
        }

        if (startOfWave)
        {
            BEnemyUnit unit = UnitManager.GetEnemyUnit();
            UnitManager.UnitsDoBattle();
            if (unit == null)
            {
                //end the battle
            }
            else
            {
                //spawn enemies
                WaveManager.enemyCount = unit.EnemyUnitsToSpawn();
            }
            startOfWave = false;
        }

        if (WaveManager.enemyCount <= 0 && !betweenWaves)
        {
            WaveManager.TriggerEndWave();
        }
    }

    //Function : StartWave
    //DESCRIPTION : Tells gameobject a new wave has started
    //PARAMETERS : none
    //RETURNS : none
    private void StartWave()
    {
        startOfWave = true;
        betweenWaves = false;
    }

    //Function : EndWave
    //DESCRIPTION : tells the gameobject the wave has ended
    //PARAMETERS : none
    //RETURNS : none
    private void EndWave()
    {
        betweenWaves = true;
    }
}
