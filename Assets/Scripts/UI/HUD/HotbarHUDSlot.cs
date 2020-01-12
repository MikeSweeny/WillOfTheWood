using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotbarHUDSlot : HUDElement
{
    private HotbarSlot slot;
    private Image image;

    //Function : Start
    //DESCRIPTION : called when the object is initialized after Awake
    //PARAMETERS : none
    //RETURNS : none
    private void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    public override void UpdateElement()
    {
        if (slot != null && slot.ability != null)
        {
            image.sprite = slot.ability.abilityImage;
        }
    }

    public void SetHotbarSlot(HotbarSlot hotbarSlot)
    {
        slot = hotbarSlot;
    }
}
