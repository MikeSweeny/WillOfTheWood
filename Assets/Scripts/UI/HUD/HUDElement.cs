//FILE          :   HUDElement.cs
//PROJECT       :   project
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   DD/MM/YYYY
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : HUDElement
//PURPOSE : acts as an element in the HUD
public abstract class HUDElement : MonoBehaviour
{

    //Function : UpdateElement
    //DESCRIPTION : Updates the relevant information to the element
    //PARAMETERS : none
    //RETURNS : none
    public abstract void UpdateElement();
}
