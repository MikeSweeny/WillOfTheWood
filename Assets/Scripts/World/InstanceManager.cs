//FILE : InstanceManager.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Timothy Olenio
//FIRST VERSION : 06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : InstanceManager
//PURPOSE : This class calls the clock to update
public class InstanceManager : MonoBehaviour
{
    private const float incrementClockTime = 1f;
    private void Start()
    {
        InvokeRepeating("ProgressTime()", incrementClockTime, incrementClockTime);

    }

    private void Update()
    {        

    }

    private void ProgressTime()
    {
        Clock.UpdateClock(incrementClockTime);

    }
}
