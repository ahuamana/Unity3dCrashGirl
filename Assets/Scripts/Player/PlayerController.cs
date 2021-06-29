using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float verticalInput;
    float horizontalInput;
    public float speedPlayer = 5f;
    public float speedPlayerRotation = 250;
    public float jumpSpeed = 200f;

    private Animator anim;


    public bool isGrounded;
    public float jumpHeight = 1.0f;
    public float gravityValue = -9.81f;
    public Vector3 playerVelocity;

    public float groundDistance = 0.1f;

    Vector3 direction;
    Vector3 moveDir;
    public CharacterController controller;
    public float turnSmothTime = 0.1f;
    float turnSmoothVelocity;


    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        //Verificar si pisa el suelo o no
        //isGrounded = Physics.Raycast(controller.transform.position, Vector3.down, groundDistance);
        isGrounded = controller.isGrounded; // changed with character controller to detect if is grounded

        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
            //anim.ResetTrigger("Jump");//change the state of jumping if player is grounded
        }



        //Saltar
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //rigidbody.AddForce(new Vector2(0, jumpSpeed));
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -2 * gravityValue);
            anim.SetTrigger("Jump");

        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        //Fin Saltar

        //Movimiento
        ////avanzar
        verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.forward * speedPlayer * Time.deltaTime * verticalInput);


        ////rotar
        horizontalInput = Input.GetAxis("Horizontal");
        //transform.Rotate(Vector3.up * speedPlayerRotation * Time.deltaTime * horizontalInput);



        direction = new Vector3(horizontalInput, 0f, verticalInput).normalized;



        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;//angulo a donde girar
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmothTime);

            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            controller.Move(moveDir.normalized * speedPlayer * Time.deltaTime); // move in diferent directions
        }

        


    }

    private void FixedUpdate()
    {

        Debug.Log(verticalInput + " + " + horizontalInput);

        //Asignar animacion si presiona "arriba" o "abajo" o derecha izquierda
        if (verticalInput != 0)
        {
            anim.SetFloat("Speed", Mathf.Abs(verticalInput));
        }
        else {
            anim.SetFloat("Speed", Mathf.Abs(horizontalInput));
        }
        
        

        


        


    }

   
}
