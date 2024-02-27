using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour
{
    [Header("References")]
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI priceText;
    public Image icon;
    public Item item;
    public bool isEquipSlot;
}
