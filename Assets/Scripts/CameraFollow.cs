using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float speed = 4f;
    //public GameObject target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);

        /*
        if (target != null)
        {
            Vector3 camPos = gameObject.transform.position;
            gameObject.transform.position = new Vector3(target.transform.position.x, camPos.y, camPos.z);
        }
        */
    }
}
