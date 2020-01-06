//FILE          :   HTargetStatus.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   17/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : HTargetStatus
//PURPOSE : retrieves the target status info
public class HTargetStatus : HUDElement
{

    private CharacterBase target;
    private Slider healthBar;

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    private void Awake()
    {
        healthBar = transform.Find("HealthBar").GetComponent<Slider>();
    }

    //Function : UpdateElement
    //DESCRIPTION : Updates the relevant information to the element
    //PARAMETERS : none
    //RETURNS : none
    public override void UpdateElement()
    {
        if (player.GetPlayerTarget() != null)
        {
            target = player.GetPlayerTarget().GetComponent<CharacterBase>();
            healthBar.value = target.GetHealthPercent();
        }
        else
            target = null;
    }
}
