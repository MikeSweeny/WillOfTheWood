//FILE          :   PaddedShirt.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   7/1/2020
using UnityEngine;

//NAME : PaddedShirt
//PURPOSE : The child class of iarmour for the PaddedShirt weapon
public class PaddedShirt : IArmour
{
    //Function : start
    //DESCRIPTION : sets the stats for PaddedShirt on start
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        stats = new PaddedShirtStats();
    }
}
