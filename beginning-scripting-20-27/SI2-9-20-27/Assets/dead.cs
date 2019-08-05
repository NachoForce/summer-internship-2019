using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{
    enum Direction {North, South, East, West};
    // Start is called before the first frame update
    void Start()
    {
        Direction myDirection = Direction.North;
        InvokeRepeating("ChangeColor", 2, 1);
        if (Input.GetKey(KeyCode.Space)) {
            Destroy(this.gameObject, 4.0f);
        }  
        switch(myDirection) {
            case Direction.North: 
                Debug.Log("North");
                break;
            case Direction.South:
                Debug.Log("South");
                break;
            case Direction.East:
                Debug.Log("East");
                break;
            case Direction.West:
                Debug.Log("West");
                break;
        }
    }

    void ChangeColor() {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }


}
