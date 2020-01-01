//FILE          :   UMainMenuButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   31/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//NAME : UMainMenuButton
//PURPOSE : loads the main menu scene
public class UMainMenuButton : UIButton
{
    //Function : Clicked
    //DESCRIPTION : Calls the function in the scene manager that loads the main menu scene
    //PARAMETERS :  none
    //RETURNS : none
    public override void Clicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
