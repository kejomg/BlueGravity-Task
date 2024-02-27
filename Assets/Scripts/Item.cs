using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum EquipSlot
{
    Headgear,
    Face,
    Armor,
    Pants,
    Dagger,

    COUNT,
}

[CreateAssetMenu(fileName = "Create Item", menuName = "Items/Create New")]
public class Item: ScriptableObject
{
    public string    itemName;
    public int       itemPrice;
    public EquipSlot itemSlot;
    public Sprite    itemIcon;
}


