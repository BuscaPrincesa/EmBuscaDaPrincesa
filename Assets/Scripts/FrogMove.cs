using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMove : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    public float speed = 4f;
    public float lerpRate = 5f;
    public float burst = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(speed, rb.velocity.y);

        // Correcao do x do sapo empurrado. Nao se comportou bem:
        float xFrog = Camera.main.transform.position.x;
        if (transform.position.x < xFrog) {
            rb.velocity = new Vector2(rb.velocity.x * burst, rb.velocity.y);
        }


        if (Input.GetMouseButtonDown(0) && rb.velocity.y==0)
        {
            rb.gravityScale = -rb.gravityScale;
            sr.flipY = !sr.flipY;
        }

        
        // Correcao do x do sapo empurrado. Nao se comportou bem:
        //Vector3 initialPosition = transform.position;
        //Vector3 finalPosition = new Vector3(Camera.main.transform.position.x, initialPosition.y, initialPosition.z);
        //transform.position = Vector3.Lerp(initialPosition, finalPosition, lerpRate * Time.deltaTime);
    }
}
