using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        myInt = CountToTen(myInt);
        Debug.Log(myInt);
    }

    int CountToTen(int number) {
        int ret = number; 
        while (ret != 10) {
            Debug.Log("Your number is " + ret);
            ret++;
            if (ret == 10) {
                Debug.Log("Your number is 10!");
            }
        }
        return ret;
    }
    // Update is called once per frame
}
