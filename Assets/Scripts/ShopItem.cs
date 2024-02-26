using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemSlot
{
    HEADGEAR,
    FACE_ACCESSORY,
    BODY_ARMOR,
    PANTS,
    ELBOW_PAD,
    BOOTS,
    WEAPON,
}

public struct Item
{
    public string itemName;
    public Sprite itemIcon;
    public int itemPrice;
    public ItemSlot slot;
}
