using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnComponent : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        GameController.Instance.BirdScore();
    }

    private void OnBecameInvisible()
    {
        GameController.Instance.columnPool.columnPool.Enqueue(this.gameObject);
    }
}
