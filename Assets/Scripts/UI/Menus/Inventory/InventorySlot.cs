using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    private Image image;

    private void Awake()
    {
        image = transform.GetChild(0).GetChild(0).GetComponent<Image>();
    }

    public void SetImageSprite(Sprite sprite)
    {
        image.sprite = sprite;
    }

    public Sprite GetImageSprite()
    {
        return image.sprite;
    }
}
