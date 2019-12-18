//FILE          :   PlayerHUD.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   17/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : PlayerHUD
//PURPOSE : serves as the player HUD
public class PlayerHUD : MonoBehaviour
{
    private List<HUDElement> elements;

    //Function : Awake
    //DESCRIPTION : called when the object is initialized
    //PARAMETERS : none
    //RETURNS : none
    void Awake()
    {
        Player player = GameObject.Find("Player").GetComponent<Player>();
        elements = new List<HUDElement>();
        for (int i = 0; i < transform.childCount; ++i)
        {
            elements.Add(transform.GetChild(i).GetComponent<HUDElement>());
        }

        foreach (HUDElement element in elements)
        {
            element.SetPlayer(player);
        }
    }


    //Function : Update
    //DESCRIPTION : called ever frame
    //PARAMETERS : none
    //RETURNS : none
    void Update()
    {
        foreach (HUDElement element in elements)
        {
            element.UpdateElement();
        }
    }
}
