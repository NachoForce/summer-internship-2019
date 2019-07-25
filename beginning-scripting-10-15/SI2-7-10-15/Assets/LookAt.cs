using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    
    public GameObject bullet; 
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        if (Input.GetKeyDown(KeyCode.Space)) {
            bullet.SetActive(true);
        }
    }
}
