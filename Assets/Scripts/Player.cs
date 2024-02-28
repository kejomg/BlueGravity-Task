using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    //References for the sprite renderers for the equipped items.
    [Header("Equipments")]
    public SpriteRenderer headSprite;
    public SpriteRenderer faceSprite;
    public SpriteRenderer armorSprite;
    public SpriteRenderer pantsSprite;
    public SpriteRenderer weaponSpriteL;
    public SpriteRenderer weaponSpriteR;

    //References for the inventory and equipment window.
    [Header("Inventory")]
    public Inventory inventory;
    public EquipmentsWindow equipments;

    //Equips an item.
    public void EquipItem(int index)
    {
        Item itemToEquip = inventory.items[index];
        int equipSlot = (int)itemToEquip.itemSlot;

        //Removes the item from the inventory (as it is now equipped, and will be in a different list)
        inventory.RemoveItem(itemToEquip);

        //Equips the equipped item in that slot, if there's one.
        if (equipments.equips[equipSlot] != null) equipments.UnequipItem(equipSlot);

        equipments.equips[equipSlot].icon.gameObject.SetActive(true);
        equipments.equips[equipSlot].item = itemToEquip;
        equipments.UpdateUI(equipments.equips[equipSlot]);

        inventory.inventoryWindow.GenerateInventory();
        EquipOnCharacter(itemToEquip);
    }

    //Visually equips an item.
    public void EquipOnCharacter(Item itemToEquip)
    {
        switch (itemToEquip.itemSlot)
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
