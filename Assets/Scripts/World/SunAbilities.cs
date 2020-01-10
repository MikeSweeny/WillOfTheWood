using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunAbilities : MonoBehaviour
{

    Clock clock;
    public GameObject sun;
    float sunInitialIntensity;
    float Hours;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetTime();
        UpdateSun();
        Debug.Log("Time of day: " + Hours);
    }

    private float GetTime()
    {
        float i;
        i = Clock.GetTimeOfDay()/3600;
        Hours = i / 24;

        return Hours;
    }
    void UpdateSun()
    {
        sun.transform.rotation = Quaternion.Euler((Hours * 360f)-180, 170, 0);

    }
}
