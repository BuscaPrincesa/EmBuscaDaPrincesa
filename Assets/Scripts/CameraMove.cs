using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public static CameraMove instance = null;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float newX = transform.position.x + speed * Time.deltaTime;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }

    public void SetSpeed(float speed) {
        this.speed = speed;
    }

    public void StopCamera() {
        this.speed = 0f;
    }
}
