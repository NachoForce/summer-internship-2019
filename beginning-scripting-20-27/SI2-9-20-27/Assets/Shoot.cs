using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    
    public Rigidbody bullet;
    public Transform start;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.Space)) {
            Instantiate(bullet, transform.position, transform.rotation); 
       }
    }
}
