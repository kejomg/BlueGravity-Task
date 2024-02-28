using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    //Interface for Interactable Objects. Used in the Shopkeeper and in the Door.
    void DisplayKey(bool state);
    void StartInteraction();
    void FinishInteraction();
}
