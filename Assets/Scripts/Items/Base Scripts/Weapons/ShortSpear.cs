//FILE          :   ShortSpear.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   7/1/2020
using UnityEngine;

//NAME : ShortSpear
//PURPOSE : The child class of iWeapon for the shortspear weapon
public class ShortSpear : IWeapon
{
    //Function : start
    //DESCRIPTION : sets the stats for shortspear on start
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        stats = new ShortSpearStats();
        ItemCost = 10;
    }
}
