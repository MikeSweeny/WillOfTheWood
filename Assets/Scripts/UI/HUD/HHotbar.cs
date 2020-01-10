//FILE          :   HHotbar.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Gavin McGuire
//FIRST VERSION :   17/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NAME : HHotbar
//PURPOSE : displays the abilities / items that are bound to the hotbar
public class HHotbar : HUDElement
{
    private Transform hotbarHolder1;
    private Transform hotbarHolder2;

    private void Start()
    {
        hotbarHolder1 = transform.Find("LeftHotbarHolder");
        hotbarHolder2 = transform.Find("RightHotbarHolder");
        for (int i = 0; i < player.GetHotbar().Count; ++i)
        {
            if (i < hotbarHolder1.childCount)
            {
                hotbarHolder1.GetChild(i).GetComponent<HotbarHUDSlot>().SetHotbarSlot(player.GetHotbar()[i]);
            }
            if (i >= hotbarHolder1.childCount)
            {
                hotbarHolder2.GetChild(i - hotbarHolder1.childCount).GetComponent<HotbarHUDSlot>().SetHotbarSlot(player.GetHotbar()[i]);
            }
        }
    }

    //Function : UpdateElement
    //DESCRIPTION : Updates the relevant information to the element
    //PARAMETERS : none
    //RETURNS : none
    public override void UpdateElement()
    {
        throw new System.NotImplementedException();
    }
}
