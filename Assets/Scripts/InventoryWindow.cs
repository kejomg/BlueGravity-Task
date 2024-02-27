using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryWindow : MonoBehaviour
{
    public Player player;
    public UIController UI;
    public GameObject ItemShopPrefab;
    public Transform content;
    public TextMeshProUGUI goldText;

    private void OnEnable()
    {
        GenerateInventory();
    }

    public void GenerateInventory()
    {
        for (int i = content.childCount - 1; i >= 0; i--)
        {
            Destroy(content.GetChild(i).gameObject);
        }

        int index = 0;
        foreach (Item item in player.inventory.items)
        {
            int i = index;
            GameObject itemSlot = Instantiate(ItemShopPrefab, content);
            itemSlot.GetComponent<Button>().onClick.AddListener(delegate () { SellItem(i); });
            UpdateUI(itemSlot, item);
            index++;
        }

        goldText.text = player.inventory.gold.ToString()+"G";
    }

    void UpdateUI(GameObject go, Item item)
    {
        ItemSlot itemSlot = go.GetComponent<ItemSlot>();
        itemSlot.item = item;
        itemSlot.nameText.text = item.itemName;
        itemSlot.priceText.text = (item.itemPrice/3).ToString() + " G";
        itemSlot.icon.sprite = item.itemIcon;
    }

    void SellItem(int index)
    {
        if (UI.shopPanel.activeSelf)
        {
            player.inventory.SellItem(index);
        }
    }
}
