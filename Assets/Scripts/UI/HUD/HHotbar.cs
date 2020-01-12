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
    private List<HotbarHUDSlot> slots;

    //Function : Start
    //DESCRIPTION : called when the object is initialized after Awake
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        hotbarHolder1 = transform.Find("LeftHotbarHolder");
        hotbarHolder2 = transform.Find("RightHotbarHolder");
        slots = new List<HotbarHUDSlot>();
        for (int i = 0; i < player.GetHotbar().Count; ++i)
        {
            if (i < hotbarHolder1.childCount)
            {
                slots.Add(hotbarHolder1.GetChild(i).GetComponent<HotbarHUDSlot>());
            }
            if (i >= hotbarHolder1.childCount)
            {
                slots.Add(hotbarHolder2.GetChild(i).GetComponent<HotbarHUDSlot>());
            }
            slots[i].SetHotbarSlot(player.GetHotbar()[i]);
        }
    }

    //Function : UpdateElement
    //DESCRIPTION : Updates the relevant information to the element
    //PARAMETERS : none
    //RETURNS : none
    public override void UpdateElement()
    {
        for (int i = 0; i < slots.Count; ++i)
        {
            slots[i].UpdateElement();
        }
    }
}
