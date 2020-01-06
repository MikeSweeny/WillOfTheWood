//FILE          :   MailArmour.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Jonathan Parsons
//FIRST VERSION :   7/1/2020
using UnityEngine;

//NAME : PaddedShirt
//PURPOSE : The child class of iarmour for the Mail Armour
public class Mail : IArmour
{
    //Function : start
    //DESCRIPTION : sets the stats for Mail Armour on start
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        stats = new MailStats();
    }
}
