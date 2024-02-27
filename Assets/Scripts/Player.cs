using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Equipments")]
    public EquipSlot headgear;
    public EquipSlot face;
    public EquipSlot armor;
    public EquipSlot pants;
    public EquipSlot dagger;
    public Inventory inventory;

    public void EquipItem(EquipSlot slot, Item item)
    {

    }
}
