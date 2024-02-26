using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    public IInteractable target;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Interactable"))
        {
            if(other.TryGetComponent(out IInteractable interactable))
            {
                interactable.DisplayKey(true);
                target = interactable;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.CompareTag("Interactable"))
        {
            if (other.TryGetComponent(out IInteractable interactable))
            {
                interactable.DisplayKey(false);
                if (target != null)
                {
                    target.FinishInteraction();
                    target = null;
                }
            }
        }
    }

    private void Update()
    {
        if (target != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                target.StartInteraction();
            }
        }
    }
}
