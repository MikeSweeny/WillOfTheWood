//FILE          :   ElvenArmour.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   7/1/2020
using UnityEngine;

//NAME : PaddedShirt
//PURPOSE : The child class of iarmour for the Elven Armour
public class ElvenArmour : IArmour
{
    //Function : start
    //DESCRIPTION : sets the stats for Elven Armour on start
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        stats = new ElvenArmourStats();
    }
}
