using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public InventoryWindow inventoryWindow;
    public int gold;
    public int maxSlots;
    public int valueDecreaseFactor = 3;

    //Checks if there's space in the inventory.
    public bool hasSpace()
    {
        return items.Count < maxSlots;
    }

    //Adds an item to the inventory;
    public void AddItem(Item item)
    {
        items.Add(item);
        inventoryWindow.GenerateInventory();
    }

    //Sells an item. This is called on click, when the shop tab is open. Items are sold for 1/valueDecreaseFactor of the original value.
    internal void SellItem(int index)
    {
        AddGold(items[index].itemPrice/valueDecreaseFactor);
        RemoveItem(items[index]);
        inventoryWindow.GenerateInventory();
    }

    //Removes an item from the inventory.
    public void RemoveItem(Item item)
    {
        items.Remove(item);
        inventoryWindow.GenerateInventory();
    }

    //Adds gold to the player's "purse".
    public void AddGold(int amount)
    {
        gold += amount;
        inventoryWindow.goldText.text = gold.ToString() + " G";
    }
}
