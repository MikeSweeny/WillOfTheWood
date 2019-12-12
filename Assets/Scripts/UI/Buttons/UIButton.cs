//FILE          :   UIButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   12/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UIButton
//PURPOSE : parent to all the button scripts
public abstract class UIButton : MonoBehaviour
{

    //Function : Clicked
    //DESCRIPTION : called when the button is clicked on
    //PARAMETERS : none
    //RETURNS : none
    public abstract void Clicked();
}
