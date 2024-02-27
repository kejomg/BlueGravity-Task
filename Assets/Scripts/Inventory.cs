using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public InventoryWindow inventoryWindow;

    public TextMeshProUGUI goldText;
    public int gold;

    public bool hasSpace()
    {
        return items.Count < 10;
    }

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    internal void SellItem(int index)
    {
        AddGold(items[index].itemPrice/3);
        RemoveItem(items[index]);
        inventoryWindow.GenerateInventory();
    }

    private void RemoveItem(Item item)
    {
        items.Remove(item);
    }

    private void AddGold(int amount)
    {
        gold +=amount;
    }
}
