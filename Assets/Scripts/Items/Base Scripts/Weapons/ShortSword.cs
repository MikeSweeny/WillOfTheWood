//FILE          :   ShortSword.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   7/1/2020
using UnityEngine;

//NAME : ShortSword
//PURPOSE : The child class of iWeapon for the shortsword weapon
public class ShortSword : IWeapon
{
    //Function : start
    //DESCRIPTION : sets the stats for sword on start
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        stats = new ShortSwordStats();
    }
}
