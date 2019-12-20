//FILE : InstanceManager.cs
//PROJECT : Will of the Woods
//PROGRAMMER : Timothy Olenio
//FIRST VERSION : 06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

//NAME : InstanceManager
//PURPOSE : This class calls the clock to update
public class InstanceManager : MonoBehaviour
{
    private const float incrementClockTime = 1f;

    private Scene scene; 
    //Function : Start
    //DESCRIPTION : Invokes ProgressTime by the incrmentClockTime const (should be 1 second)
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        InvokeRepeating("ProgressTime", incrementClockTime, incrementClockTime);

        var parameters = new LoadSceneParameters(LoadSceneMode.Additive);

        scene = SceneManager.LoadScene("WorldTerrain", parameters);
        Debug.Log("Load scene: " + scene.name);
        scene = SceneManager.LoadScene("Town", parameters);
        Debug.Log("Load scene: " + scene.name);
        scene = SceneManager.LoadScene("TownNPC's", parameters);
        Debug.Log("Load scene: " + scene.name);


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
