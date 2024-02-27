using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public InventoryWindow inventoryWindow;
    public int gold;

    public bool hasSpace()
    {
        return items.Count < 10;
    }

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void UpdateUI()
    {
        int index = 0;
        foreach(Item item in items)
        {
            RectTransform rt = item.icon.rectTransform;
            Item slot = inventoryWindow.content.GetChild(index).GetComponent<Item>(); 
            slot.nameText.text = item.itemName;
            slot.priceText.text = item.itemPrice.ToString() + "G";
            slot.icon.sprite = item.itemIcon;

            /*
            Definitely not the prettiest thing to do, but the sprites came in different
            sizes and shapes to fit the character, so I manually fixed them according to the slot.
            Would definitely not do this in a real project, since I would have proper icons.
             */

            if (item.itemSlot == ItemSlot.Headgear)
            {
                rt.localScale = Vector3.one * 1.5f;
                rt.anchoredPosition = new Vector3(0, -9.36f, 0);
            }
            if (item.itemSlot == ItemSlot.Face)
            {
                rt.localScale = Vector3.one * 2f;
                rt.anchoredPosition = new Vector3(0, -9.36f, 0);
            }
            if (item.itemSlot == ItemSlot.Armor)
            {
                rt.localScale = Vector3.one * 1.5f;
                rt.anchoredPosition = new Vector3(0, 15, 0);
            }
            if (item.itemSlot == ItemSlot.Pants)
            {
                rt.localScale = Vector3.one * 1.5f;
                rt.anchoredPosition = new Vector3(0, 20, 0);
            }
            if (item.itemSlot == ItemSlot.Dagger)
            {
                rt.localScale = Vector3.one * 3f;
                rt.anchoredPosition = new Vector3(0, -9.36f, 0);
            }
            index++;
        }
    }
}
