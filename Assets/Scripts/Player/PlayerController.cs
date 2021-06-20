using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float verticalInput;
    float horizontalInput;
    public float speedPlayer = 10;
    public float speedPlayerRotation = 250;
    public float jumpSpeed = 200f;

    private Animator anim;

    private Rigidbody rigidbody;

    public bool isGrounded = false;
    public float groundDistance = 0.5f;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //avanzar
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speedPlayer * Time.deltaTime * verticalInput);
        


        //rotar
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * speedPlayerRotation * Time.deltaTime * horizontalInput);

        //Saltar
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rigidbody.AddForce(new Vector2(0, jumpSpeed));
        }


    }

    private void FixedUpdate()
    {
        //Actualizar el animator y asignar la velocidad en cada frame
        anim.SetFloat("Speed", Mathf.Abs(verticalInput));

        //
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundDistance);
        

    }

   
}
