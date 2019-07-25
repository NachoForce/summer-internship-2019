using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float speed = 10.0f; 
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.velocity = -transform.right * speed; 
        }
    }
}
