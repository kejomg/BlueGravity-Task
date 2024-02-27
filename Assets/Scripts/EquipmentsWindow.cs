using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentsWindow : MonoBehaviour
{
    public Player player;
    public List<ItemSlot> equips = new List<ItemSlot>();

    private void OnEnable()
    {
        UpdateUI(equips[0]);
        UpdateUI(equips[1]);
        UpdateUI(equips[2]);
        UpdateUI(equips[3]);
        UpdateUI(equips[4]);
    }

    public void UpdateUI(ItemSlot slot)
    {
        slot.nameText.text = slot.item.itemName;
        slot.icon.sprite = slot.item.itemIcon;
    }
}
