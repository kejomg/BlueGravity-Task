using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum ItemSlot
{
    Headgear,
    Face,
    Armor,
    Pants,
    Dagger,

    COUNT,
}

public class Item : MonoBehaviour
{
    [Header("Stats")]
    public string itemName;
    public Sprite itemIcon;
    public int itemPrice;
    public ItemSlot itemSlot;

    [Header("References")]
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI priceText;
    public Image icon;
}


