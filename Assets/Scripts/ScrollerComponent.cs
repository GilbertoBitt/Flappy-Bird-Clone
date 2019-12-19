using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ScrollerComponent : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;

    private void Start () 
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(GameController.Instance.gameOver == true)
        {
            rigidbody2D.velocity = Vector2.zero;
        } 

        if (rigidbody2D.velocity.x <= 0f && GameController.Instance.hasStarted && GameController.Instance.gameOver == false)
        {
            rigidbody2D.velocity = Vector2.right * GameController.Instance.scrollSpeed;
        }
    }
}
