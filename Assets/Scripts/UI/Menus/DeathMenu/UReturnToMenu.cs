//FILE          :  UReturnToMenu.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Michael Sweeny
//FIRST VERSION :   01/06/20
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//NAME : UReturnToMenu
//PURPOSE : returns the player to the main menu after death
public class UReturnToMenu : UIButton
{
    //Function : Clicked
    //DESCRIPTION : Calls the function in the UI event manager to open the main menu
    // and closes the Death Menu
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
