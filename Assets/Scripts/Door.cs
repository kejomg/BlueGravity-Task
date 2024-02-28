using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [Header("References")]
    public GameObject displayKey;
    public GameObject dialogue;
    public void DisplayKey(bool state) => displayKey.SetActive(state);
    public void StartInteraction() => dialogue.SetActive(true);
    public void FinishInteraction() => dialogue.SetActive(false);
}
