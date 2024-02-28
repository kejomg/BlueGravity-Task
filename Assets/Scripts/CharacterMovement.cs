using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [Header("References")]
    public UIController UI;
    public Rigidbody2D rb;
    public Animator animator;

    [Header("Movement Variables")]
    public float movementSpeed = 1f;
    Vector2 movement;
    Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Inputs. Didn't bother to use the new Input System for such a small project.
        #region INPUT
        if (Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.B)) UI.inventoryPanel.SetActive(!UI.inventoryPanel.activeSelf);
        if (Input.GetKeyDown(KeyCode.C)) UI.equipmentPanel.SetActive(!UI.equipmentPanel.activeSelf);
        if (Input.GetKeyDown(KeyCode.Escape)) UI.CloseAllPanels();
        if (Input.GetKeyDown(KeyCode.F)) GetComponent<Player>().inventory.AddGold(1000);
        #endregion
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed*Time.fixedDeltaTime);
        animator.SetBool("IsWalking", movement != Vector2.zero);

        if (movement.x < 0) transform.localScale = new Vector3(-originalScale.x, originalScale.y, 0);
        else if (movement.x > 0) transform.localScale = new Vector3(originalScale.x, originalScale.y, 0);
    }
}
