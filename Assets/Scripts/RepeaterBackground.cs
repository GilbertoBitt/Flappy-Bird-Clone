using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeaterBackground : MonoBehaviour
{

    private BoxCollider2D _boxCollider2D;
    private float _horizontalLength;
    
    // Start is called before the first frame update
    void Start()
    {
        _boxCollider2D = GetComponent<BoxCollider2D>();
//        _boxCollider2D = GetComponent(typeof(BoxCollider2D)) as BoxCollider2D;
        _horizontalLength = _boxCollider2D.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -_horizontalLength)
        {
            RepositionBackground ();
        }
    }

    private void RepositionBackground()
    {
        Vector2 groundOffSet = new Vector2(_horizontalLength * 2f, 0);
        transform.position = (Vector2) transform.position + groundOffSet;
    }
}
