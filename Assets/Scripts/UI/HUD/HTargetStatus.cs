//FILE          :   HTargetStatus.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   17/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : HTargetStatus
//PURPOSE : retrieves the target status info
public class HTargetStatus : HUDElement
{

    private CharacterBase target;

    //Function : UpdateElement
    //DESCRIPTION : Updates the relevant information to the element
    //PARAMETERS : none
    //RETURNS : none
    public override void UpdateElement()
    {
        target = player.GetPlayerTarget().GetComponent<CharacterBase>();
    }
}
