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

    //Updates the UI object for that specific slot.
    public void UpdateUI(ItemSlot slot)
    {
        slot.nameText.text = slot.item ? slot.item.itemName : "nothing";
        slot.icon.sprite = slot.item ? slot.item.itemIcon : null;
    }

    //Unequips the item in equips[index]
    public void UnequipItem(int index)
    {
        if (equips[index].item != null)
        {
            player.inventory.AddItem(equips[index].item);
            player.inventory.inventoryWindow.GenerateInventory();
            equips[index].item = null;
            equips[index].icon.gameObject.SetActive(false);
        }
        UpdateUI(equips[index]);
    }
}
