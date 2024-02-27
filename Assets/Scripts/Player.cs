using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Equipments")]
    public List<ItemSlot> equips = new List<ItemSlot>();
    public SpriteRenderer headSprite;
    public SpriteRenderer faceSprite;
    public SpriteRenderer armorSprite;
    public SpriteRenderer pantsSprite;
    public SpriteRenderer weaponSpriteL;
    public SpriteRenderer weaponSpriteR;

    [Header("Inventory")]
    public Inventory inventory;
    public EquipmentsWindow equipments;

    public void EquipItem(int index)
    {
        Item itemToEquip = inventory.items[index];
        EquipSlot slot = itemToEquip.itemSlot;
        equips[(int)slot].item = itemToEquip;
        inventory.RemoveItem(itemToEquip);

        if (equipments.equips[(int)slot] != null)
        {
            inventory.AddItem(equipments.equips[(int)slot].item);
        }
        equipments.equips[(int)slot].item = itemToEquip;
        equipments.UpdateUI(equipments.equips[(int)slot]);
        inventory.inventoryWindow.GenerateInventory();

        switch (slot)
        {
            case EquipSlot.Headgear:
                headSprite.sprite = itemToEquip.itemIcon;
                break;
            case EquipSlot.Face:
                faceSprite.sprite = itemToEquip.itemIcon;
                break;
            case EquipSlot.Armor:
                armorSprite.sprite = itemToEquip.itemIcon;
                break;
            case EquipSlot.Pants:
                pantsSprite.sprite = itemToEquip.itemIcon;
                break;
            case EquipSlot.Dagger:
                weaponSpriteL.sprite = itemToEquip.equipSprite;
                weaponSpriteR.sprite = itemToEquip.equipSprite;
                break;
            case EquipSlot.COUNT:
                break;
        }
    }
}
