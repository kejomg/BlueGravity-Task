using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Progress;

public class Shop : MonoBehaviour
{
    public Player player;

    public List<GameObject> items = new();
    public Transform content;
    public GameObject ItemShopPrefab;
    public RandomItemGenerator itemGenerator;
    void Start()
    {
        GenerateShop();
    }

    //Generates a random shop with <amount> items.
    void GenerateShop()
    {
        for (int i = 0; i < 15; i++) 
        {
            //Randomizes the item.
            GameObject go = content.GetChild(i).gameObject;
            Item item = go.GetComponent<Item>();
            itemGenerator.GenerateRandomItem(ref item);
            items.Add(go);
            UpdateUI(go);
        }
    }

    //Updates the UI.
    void UpdateUI(GameObject go)
    {
        Item item = go.GetComponent<Item>();
        RectTransform rt = item.icon.rectTransform;
        item.nameText.text = item.itemName;
        item.priceText.text = item.itemPrice.ToString() + "G";
        item.icon.sprite = item.itemIcon;

        /*
        Definitely not the prettiest thing to do, but the sprites came in different
        sizes and shapes to fit the character, so I manually fixed them according to the slot.
        Would definitely not do this in a real project, since I would have proper icons.
         */

        if (item.itemSlot == ItemSlot.Headgear)
        {
            rt.localScale = Vector3.one * 1.5f;
            rt.anchoredPosition = new Vector3(0, -9.36f, 0) ;
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
    }

    //Refreshes the shop.
    public void RefreshShop()
    {
        items.Clear();
        GenerateShop();
    }

    public void BuyItem()
    {

    }
}
