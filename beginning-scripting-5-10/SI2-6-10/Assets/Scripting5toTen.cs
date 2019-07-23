using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripting5toTen : MonoBehaviour
{
    public float speed = 5.0f; 
    Rigidbody rb;
    Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.velocity = transform.right * speed;
            myLight.enabled = true;
        } 
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.velocity = -transform.right * speed;
            myLight.enabled = false; 
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.velocity = new Vector3(0,0,1) * speed;
        }
    }
}
