using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBattle : MonoBehaviour
{
    private bool startOfWave;
    private float interludeDuration;
    private float interludeTime;
    private bool betweenWaves;

    // Start is called before the first frame update
    void Awake()
    {
        betweenWaves = true;
        interludeDuration = 10.0f;
        interludeTime = 0.0f;
        startOfWave = false;
        WaveManager.StartWave += StartWave;
        WaveManager.EndWave += EndWave;
    }

    // Update is called once per frame
    void Update()
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

    private void StartWave()
    {
        startOfWave = true;
        betweenWaves = false;
    }

    private void EndWave()
    {
        betweenWaves = true;
    }
}
