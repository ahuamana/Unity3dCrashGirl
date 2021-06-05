using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float verticalInput;
    float horizontalInput;
    public float speedPlayer = 10;
    public float speedPlayerRotation = 250;

    // Update is called once per frame
    void Update()
    {
        //avanzar
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speedPlayer * Time.deltaTime * verticalInput);

        //rotar
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * speedPlayerRotation * Time.deltaTime * horizontalInput);

        if (verticalInput != 0)
        { 
            //animacion correr
        
        }

    }
}
