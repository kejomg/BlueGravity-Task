using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Shop : MonoBehaviour
{
    public Player player;

    public List<Item> items = new();
    public Transform content;
    public GameObject ItemShopPrefab;
    void Start()
    {
        GenerateShop();
    }

    //Generates the shop items
    void GenerateShop()
    {
        int index = 0;
        foreach(Item item in items)
        {
            int i = index;
            GameObject itemSlot = Instantiate(ItemShopPrefab, content);
            itemSlot.GetComponent<Button>().onClick.AddListener(delegate () { BuyItem(i); });
            UpdateUI(itemSlot,item);
            index++;
        }
    }

    //Updates the UI.
    void UpdateUI(GameObject go, Item item)
    {
        ItemSlot itemSlot = go.GetComponent<ItemSlot>();
        itemSlot.item = item;
        itemSlot.nameText.text = item.itemName;
        itemSlot.priceText.text = item.itemPrice.ToString() + " G";
        itemSlot.icon.sprite = item.itemIcon;
    }

    public void BuyItem(int index)
    {
        Item item = items[index];

        if (player.inventory.gold >= item.itemPrice && player.inventory.hasSpace())
        {
            player.inventory.gold -= item.itemPrice;
            player.inventory.AddItem(item);
            player.inventory.inventoryWindow.GenerateInventory();

        }
    }
    //Refreshes the shop.
    public void RefreshShop()
    {
        foreach(Transform t in content)
        {
            t.gameObject.GetComponent<Button>().interactable = true;
        }
        items.Clear();
        GenerateShop();
    }
}
