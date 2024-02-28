using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Enum for the different equip slots.
public enum EquipSlot
{
    Headgear,
    Face,
    Armor,
    Pants,
    Dagger,

    COUNT,
}

//Item class.
[CreateAssetMenu(fileName = "New Item", menuName = "Items/Create New")]
public class Item: ScriptableObject
{
    public string    itemName;
    public int       itemPrice;
    public EquipSlot itemSlot;

    //There's a sprite for the icon, and the sprite that's actually equipped on the character.
    //This is only used for the Weapons, since each of them have these 2 sprites on the pack.

    public Sprite    itemIcon;
    public Sprite    equipSprite;
}


