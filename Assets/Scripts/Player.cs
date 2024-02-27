using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct EquipSlot
{
    public ItemSlot slot;
    public Item item;
}

public class Player : MonoBehaviour
{
    [Header("Equipments")]
    public EquipSlot headgear;
    public EquipSlot face;
    public EquipSlot armor;
    public EquipSlot pants;
    public EquipSlot dagger;
    public Inventory inventory;

    private void Start()
    {
        headgear.slot = ItemSlot.Headgear;
        face.slot = ItemSlot.Face;
        armor.slot = ItemSlot.Armor;
        pants.slot = ItemSlot.Pants;
        dagger.slot = ItemSlot.Dagger;
    }

    public void EquipItem(EquipSlot slot, Item item)
    {

    }
}
