using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{

    void onCollisionEnter(Collision collision)
    {
        Debug.Log("Hi");
        if (collision.gameObject.name == "Bullet") {

            Destroy(collision.gameObject);
        }
    }
}
