using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float TU = 0.10f;
    float X, Y, Z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print("Hello");
        //print(transform.position);


        X = transform.position.x;
        Y = transform.position.y;
        Z = transform.position.z;

        if (Input.GetKey(KeyCode.W))
        {
            //print("W");

            transform.position = new Vector3(X, Y + TU, Z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(X, Y - TU, Z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(X - TU, Y, Z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(X + TU, Y, Z);
        }


    }
}
