using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float verticalInput;
    float horizontalInput;
    public float speedPlayer = 5;
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

        //Verificar si pisa el suelo o no
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundDistance);


        //Movimiento
        ////avanzar
        verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.forward * speedPlayer * Time.deltaTime * verticalInput);


        ////rotar
        horizontalInput = Input.GetAxis("Horizontal");
        //transform.Rotate(Vector3.up * speedPlayerRotation * Time.deltaTime * horizontalInput);



        Vector3 monement = new Vector3(horizontalInput, 0, verticalInput).normalized;
       

        if (monement == Vector3.zero)
        {
            return;
        }

        Quaternion targetRotation = Quaternion.LookRotation(monement);
        Debug.Log(targetRotation.eulerAngles);
        targetRotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 360 * Time.fixedDeltaTime);

        ////Mover la position
        rigidbody.MovePosition(rigidbody.position + monement * speedPlayer * Time.fixedDeltaTime);
        ////Mover la rotacion
        rigidbody.MoveRotation(targetRotation);



    }

   
}
