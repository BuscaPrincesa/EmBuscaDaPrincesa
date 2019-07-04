using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMove : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(4f, rb.velocity.y);

        if (Input.GetMouseButtonDown(0))
        {
            rb.gravityScale = -rb.gravityScale;
            sr.flipY = !sr.flipY;
        }
    }
}
