//FILE          :   DarkPrincesDeathShroudArmour.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   7/1/2020
using UnityEngine;

//NAME : PaddedShirt
//PURPOSE : The child class of iarmour for the Dark Princes Death Shroud Armour
public class DarkPrincesDeathShroud : IArmour
{
    //Function : start
    //DESCRIPTION : sets the stats for the Dark Princes Death Shroud Armour on start
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        stats = new DarkPrincesDeathShroudStats();
        ItemCost = 200;
    }
}
