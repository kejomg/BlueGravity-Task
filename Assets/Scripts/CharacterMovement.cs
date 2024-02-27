using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public UIController UI;
    public float movementSpeed = 1f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.B)) UI.inventoryPanel.SetActive(!UI.inventoryPanel.activeSelf);
        if (Input.GetKeyDown(KeyCode.C)) UI.equipmentPanel.SetActive(!UI.equipmentPanel.activeSelf);
        if (Input.GetKeyDown(KeyCode.Escape)) UI.CloseAllPanels();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed*Time.fixedDeltaTime);
        animator.SetBool("IsWalking", movement != Vector2.zero);

        if (movement.x < 0) transform.localScale = new Vector3(-0.3f, 0.3f, 0);
        else if (movement.x > 0) transform.localScale = new Vector3(0.3f, 0.3f, 0);
    }
}
