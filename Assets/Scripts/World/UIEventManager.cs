//FILE          :   UIEventManager.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   06/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UIEventManager
//PURPOSE : triggers UI events
public class UIEventManager
{
    public delegate void UIEvent();

    public static event UIEvent OpenOptions;
    public static event UIEvent CloseOptions;

    public static void TriggerOptionsOpen()
    {
        if (OpenOptions != null)
            OpenOptions();
    }

    public static void TriggerOptionsClose()
    {
        if (CloseOptions != null)
            CloseOptions();
    }

}
