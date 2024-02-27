using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopkeeper : MonoBehaviour, IInteractable
{
    public GameObject InteractionKey;
    public UIController UIController;
    public void StartInteraction() => OpenShop(true);
    public void FinishInteraction() => OpenShop(false);
    public void DisplayKey(bool state) => InteractionKey.SetActive(state);

    public void OpenShop(bool state) 
    {
        if (state == UIController.shopPanel.activeSelf) return;
        UIController.shopPanel.SetActive(state);
        UIController.inventoryPanel.SetActive(state);
    }
}
