using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdComponent : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public Animator animator;
    public bool isDead = false;
    public float jumpForce;
    private static readonly int Flap = Animator.StringToHash("Flap");
    private static readonly int Die = Animator.StringToHash("Die");

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        GameController.Instance.birdInput.Bird.Flap.performed += OnFlapPerformed;
    }

    private void OnFlapPerformed(InputAction.CallbackContext ctx)
    {
        if (isDead) return;
        if (!GameController.Instance.hasStarted)
        {
            GameController.Instance.hasStarted = true;
            rigidbody.bodyType = RigidbodyType2D.Dynamic;
        }
        animator.SetTrigger(Flap);
        rigidbody.velocity = Vector2.zero;
        rigidbody.AddForce(Vector2.up * jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        rigidbody.velocity = Vector2.zero;
        isDead = true;
        animator.SetTrigger (Die);
        GameController.Instance.BirdDied();
    }
    
}
