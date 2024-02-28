using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [Header("References")]
    public GameObject shopPanel;
    public GameObject inventoryPanel;
    public GameObject equipmentPanel;
    public GameObject tutorialPanel;

    //Closes all panels.
    internal void CloseAllPanels()
    {
        shopPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        equipmentPanel.SetActive(false);
        tutorialPanel.SetActive(false);
    }
}
