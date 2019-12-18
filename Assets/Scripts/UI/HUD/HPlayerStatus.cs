﻿//FILE          :   HPlayerStatus.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   17/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : HPlayerStatus
//PURPOSE : retrieves the player status info
public class HPlayerStatus : HUDElement
{

    private Slider healthbar;
    private Slider XPBar;

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    private void Awake()
    {
        healthbar = transform.Find("HealthBar").GetComponent<Slider>();
        XPBar = transform.Find("XPBar").GetComponent<Slider>();
    }

    //Function : UpdateElement
    //DESCRIPTION : Updates the relevant information to the element
    //PARAMETERS : none
    //RETURNS : none
    public override void UpdateElement()
    {
        throw new System.NotImplementedException();
    }
}
