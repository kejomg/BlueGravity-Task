using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InventoryWindow : MonoBehaviour
{
    public Player player;
    public Transform content;

    private void OnEnable()
    {
        Inventory inv = player.GetComponent<Inventory>();
        for (int i = 0; i < inv.items.Count; i++)
        {
            Item item = content.GetChild(i).GetComponent<Item>();
            item = inv.items[i];
        }
    }
}
