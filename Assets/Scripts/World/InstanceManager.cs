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
    //Function : Start
    //DESCRIPTION : Invokes ProgressTime by the incrmentClockTime const (should be 1 second)
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        InvokeRepeating("ProgressTime", incrementClockTime, incrementClockTime);

    }

    //Function : ProgressTime
    //DESCRIPTION : calls the UpdateClock function from the Clock class, passing in the incrementClock const
    //PARAMETERS : none
    //RETURNS : none
    private void ProgressTime()
    {
        Clock.UpdateClock(incrementClockTime);

    }
}
