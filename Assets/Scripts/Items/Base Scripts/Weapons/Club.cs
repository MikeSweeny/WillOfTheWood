//FILE          :   Club.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   7/1/2020
using UnityEngine;

//NAME : Mace
//PURPOSE : The child class of iWeapon for the Club weapon
public class Club : IWeapon
{
    //Function : start
    //DESCRIPTION : sets the stats for Club on start
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        stats = new ClubStats();
    }
}
