//FILE          :   UQuitButton
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   12/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UQuitButton
//PURPOSE : calls the function to quit the game
public class UQuitButton : UIButton
{
    //Function : Clicked
    //DESCRIPTION : closes the application
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        Application.Quit();
    }
}
