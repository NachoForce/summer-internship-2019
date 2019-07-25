using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown () {
        rb.velocity = new Vector3(0.0f , 0.0f, -100.0f * Time.deltaTime);
    }   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            rb.velocity = transform.right * 10.0f;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            rb.velocity = -transform.right * 10.0f;
            
        }
        else if (Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = new Vector3(0.0f , 0.0f, 100.0f * Time.deltaTime); 
        }
        Debug.Log(Input.GetAxis("Horizontal"));        
    }


}
