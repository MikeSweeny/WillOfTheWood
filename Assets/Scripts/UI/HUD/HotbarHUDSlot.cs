using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotbarHUDSlot : MonoBehaviour
{
    private HotbarSlot slot;
    private Image image;

    // Start is called before the first frame update
    void Awake()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slot != null)
        {
            
        }
    }

    public void SetHotbarSlot(HotbarSlot hotbarSlot)
    {
        slot = hotbarSlot;
    }
}
