using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//This script controlls the Inventory Window.
public class InventoryWindow : MonoBehaviour
{
    [Header("References")]
    public Player player;
    public UIController UI;
    public GameObject ItemShopPrefab;
    public Transform content;
    public TextMeshProUGUI goldText;

    private void OnEnable()
    {
        GenerateInventory();
    }

    //Re-generates the inventory, updating the icons of the itens that are actually in the inventory.
    public void GenerateInventory()
    {
        //Destroys every inventory item slot.
        for (int i = content.childCount - 1; i >= 0; i--)
        {
            Destroy(content.GetChild(i).gameObject);
        }

        //Instantiate new slots for each item, with the function to equip/sell items in their Button.onClick
        int index = 0;
        foreach (Item item in player.inventory.items)
        {
            int i = index;
            GameObject itemSlot = Instantiate(ItemShopPrefab, content);
            itemSlot.GetComponent<Button>().onClick.AddListener(delegate () { SellOrEquipItem(i); });
            UpdateUI(itemSlot, item);
            index++;
        }

        goldText.text = player.inventory.gold.ToString()+" G";
    }

    //Updates the UI for that specific slot.
    void UpdateUI(GameObject go, Item item)
    {
        ItemSlot itemSlot = go.GetComponent<ItemSlot>();
        itemSlot.item = item;
        itemSlot.nameText.text = item.itemName;
        itemSlot.priceText.text = (item.itemPrice/player.inventory.valueDecreaseFactor).ToString() + " G";
        itemSlot.icon.sprite = item.itemIcon;
    }

    //Sells or equip an item. If the shop is open, items will be sold. Else, they'll be equipped.
    void SellOrEquipItem(int index)
    {
        if (UI.shopPanel.activeSelf)
        {
            player.inventory.SellItem(index);
        }
        else
        {
            player.EquipItem(index);
        }
    }
}
