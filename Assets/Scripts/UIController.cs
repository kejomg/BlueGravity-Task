using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject shopPanel;
    public GameObject inventoryPanel;
    public GameObject equipmentPanel;

    internal void CloseAllPanels()
    {
        shopPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        equipmentPanel.SetActive(false);
    }
}
