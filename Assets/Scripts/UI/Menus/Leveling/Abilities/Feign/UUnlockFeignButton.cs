//FILE          :   UUnlockFeignButton.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   09/01/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : UUnlockFeignButton
//PURPOSE : unlocks the Feign ability
public class UUnlockFeignButton : UIButton
{
    //Function : Clicked
    //DESCRIPTION : calls the function in the ability manager 
    //that unlocks the desired ability
    //PARAMETERS : none
    //RETURNS : none
    public override void Clicked()
    {
        AbilityManager.TriggerUnlockFeign();
    }
}
