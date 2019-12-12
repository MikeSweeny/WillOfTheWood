﻿//FILE          :   UIEventManager.cs
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

    public static event UIEvent OpenMainMenu;
    public static event UIEvent CloseMainMenu;
    public static event UIEvent OpenSaveMenu;
    public static event UIEvent CloseSaveMenu;
    public static event UIEvent OpenLoadMenu;
    public static event UIEvent CloseLoadMenu;
    public static event UIEvent OpenPause;
    public static event UIEvent ClosePause;
    public static event UIEvent OpenOptions;
    public static event UIEvent CloseOptions;
    public static event UIEvent OpenQuests;
    public static event UIEvent CloseQuests;
    public static event UIEvent OpenShop;
    public static event UIEvent CloseShop;
    public static event UIEvent OpenInventory;
    public static event UIEvent CloseInventory;
    public static event UIEvent OpenLeveling;
    public static event UIEvent CloseLeveling;

    //Function : TriggerOpenMainMenu
    //DESCRIPTION : Opens the main menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerOpenMainMenu()
    {
        if (OpenMainMenu != null)
            OpenMainMenu();
    }

    //Function : TriggerCloseMainMenu
    //DESCRIPTION : Closes the main menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerCloseMainMenu()
    {
        if (CloseMainMenu != null)
            CloseMainMenu();
    }

    //Function : TriggerOpenSaveMenu
    //DESCRIPTION : Opens the save menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerOpenSaveMenu()
    {
        if (OpenSaveMenu != null)
            OpenSaveMenu();
    }

    //Function : TriggerCloseSaveMenu
    //DESCRIPTION : Closes the save menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerCloseSaveMenu()
    {
        if (CloseSaveMenu != null)
            CloseSaveMenu();
    }

    //Function : TriggerOpenLoadMenu
    //DESCRIPTION : Opens the load menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerOpenLoadMenu()
    {
        if (OpenLoadMenu != null)
            OpenLoadMenu();
    }

    //Function : TriggerCloseLoadMenu
    //DESCRIPTION : Closes the load menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerCloseLoadMenu()
    {
        if (CloseLoadMenu != null)
            CloseLoadMenu();
    }

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

    //Function : TriggerQuestsOpen
    //DESCRIPTION : Opens the quest menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerQuestsOpen()
    {
        if (OpenQuests != null)
            OpenQuests();
    }

    //Function : TriggerQuestsClose
    //DESCRIPTION : Close the quest menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerQuestsClose()
    {
        if (CloseQuests != null)
            CloseQuests();
    }

    //Function : TriggerOpenShop
    //DESCRIPTION : Open the shop menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerOpenShop()
    {
        if (OpenShop != null)
            OpenShop();
    }

    //Function : TriggerCloseShop
    //DESCRIPTION : Close the shop menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerCloseShop()
    {
        if (CloseShop != null)
            CloseShop();
    }

    //Function : TriggerOpenInventory
    //DESCRIPTION : Open the inventory menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerOpenInventory()
    {
        if (OpenInventory != null)
            OpenInventory();
    }

    //Function : TriggerCloseInventory
    //DESCRIPTION : Close the inventory menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerCloseInventory()
    {
        if (CloseInventory != null)
            CloseInventory();
    }

    //Function : TriggerOpenLeveling
    //DESCRIPTION : Opens the leveling menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerOpenLeveling()
    {
        if (OpenLeveling != null)
            OpenLeveling();
    }

    //Function : TriggerCloseLeveling
    //DESCRIPTION :Close the leveling menu
    //PARAMETERS : none
    //RETURNS : none
    public static void TriggerCloseLeveling()
    {
        if (CloseLeveling != null)
            CloseLeveling();
    }
}
