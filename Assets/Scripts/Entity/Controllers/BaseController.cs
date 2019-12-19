//FILE: BaseController.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 19/12/2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME: BaseController
//PURPOSE: the base class for the controllers
public abstract class BaseController : MonoBehaviour
{
    public Collider weaponCollider;

    //Function: ToggleWeaponCollider
    //DESCRIPTION: this function is used to turning the collider off and on for the weapon object
    //PARAMETERS: None
    //RETURNS: None
    public void ToggleWeaponCollider()
    {
        if (weaponCollider)
        {
            weaponCollider.enabled = !weaponCollider.enabled;
        }
    }

    //Function: Movement
    //DESCRIPTION: this function is a virtual function used for children of the controller that need to override it
    //PARAMETERS: float verticalMovement
    //RETURNS: None
    public virtual void Movement(float verticalMovement)
    {

    }

    //Function: Attack
    //DESCRIPTION: this function is used for overriding in the children so that they will have their attack functionality
    //PARAMETERS: None
    //RETURNS: None
    public abstract void Attack();
}
