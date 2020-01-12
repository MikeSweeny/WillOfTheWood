//FILE          :   HClock.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   06/01/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : HClock
//PURPOSE : displays the clock information to the screen
public class HClock : HUDElement
{
    private Image clock;
    private Text dayCountText;

    //Function : Start
    //DESCRIPTION : called when the object is initialized after Awake
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        clock = transform.Find("Clock").GetComponent<Image>();
        dayCountText = transform.Find("DayCountText").GetComponent<Text>();
    }

    //Function : UpdateElement
    //DESCRIPTION : Updates the relevant information to the element
    //PARAMETERS : none
    //RETURNS : none
    public override void UpdateElement()
    {
        float rotAngle = ((Clock.GetTimeOfDay() / 3600)/24)*360f;
        //clock.transform.RotateAround(clock.transform.position, Vector3.forward, rotAngle);
        clock.transform.localRotation = Quaternion.Euler(0, 0, rotAngle + 180);
    }
}
