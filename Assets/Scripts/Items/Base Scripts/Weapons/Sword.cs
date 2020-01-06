//FILE          :   Sword.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   18/12/2019
using UnityEngine;

//NAME : Sword
//PURPOSE : The child class of iWeapon for the sword weapon
public class Sword : IWeapon
{
    //Function : start
    //DESCRIPTION : sets the stats for sword on start
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        stats = new SwordStats();
    }
}
