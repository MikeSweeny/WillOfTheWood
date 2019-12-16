//FILE          :   MAudioMenu.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   16/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : MAudioMenu
//PURPOSE : serves as the audio menu
public class MAudioMenu : Menu
{

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    private void Awake()
    {
        gameObject.SetActive(false);
        UIEventManager.OpenAudioMenu += OpenMenu;
        UIEventManager.CloseAudioMenu += CloseMenu;
    }

    //Function : OnDestroy
    //DESCRIPTION : Called when the object is destroyed
    //PARAMETERS : none
    //RETURNS : none
    private void OnDestroy()
    {
        UIEventManager.OpenAudioMenu -= OpenMenu;
        UIEventManager.CloseAudioMenu -= CloseMenu;
    }
}
