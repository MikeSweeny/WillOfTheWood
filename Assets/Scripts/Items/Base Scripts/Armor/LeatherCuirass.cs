//FILE          :   LeatherCuirass.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   7/1/2020
using UnityEngine;

//NAME : PaddedShirt
//PURPOSE : The child class of iarmour for the LeatherCuirass armour
public class LeatherCuirass : IArmour
{
    //Function : start
    //DESCRIPTION : sets the stats for LeatherCuirass on start
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        stats = new LeatherCuriassStats();
        ItemCost = 10;
    }
}
