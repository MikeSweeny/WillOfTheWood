using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemSlot : MonoBehaviour
{
    private Image itemImage;
    private UShopItemButton button;

    private void Awake()
    {
        button = transform.GetChild(0).GetComponent<UShopItemButton>();
    }

    public void SetItem(Item item)
    {
        button.SetItem(item);
        itemImage.sprite = item.GetSprite().sprite;
    }

    public void SetButtonTarget(CharacterBase character)
    {
        button.SetTarget(character);
    }
}
