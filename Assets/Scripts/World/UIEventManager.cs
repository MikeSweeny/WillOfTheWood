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

    public static event UIEvent OpenPause;
    public static event UIEvent ClosePause;
    public static event UIEvent OpenOptions;
    public static event UIEvent CloseOptions;

    //Function : TriggerOpenPause
    //DESCRIPTION : Opens the pause menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerOpenPause()
    {
        if (OpenPause != null)
            OpenPause();
    }

    //Function : TriggerClosePause
    //DESCRIPTION : Closes the pause menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerClosePause()
    {
        if (ClosePause != null)
            ClosePause();
    }

    //Function : TriggerOptionsOpen
    //DESCRIPTION : Opens the options menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerOptionsOpen()
    {
        if (OpenOptions != null)
            OpenOptions();
    }

    //Function : TriggerOptionsClose
    //DESCRIPTION : Closes the options menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerOptionsClose()
    {
        if (CloseOptions != null)
            CloseOptions();
    }

}
