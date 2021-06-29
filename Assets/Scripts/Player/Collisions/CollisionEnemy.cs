using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemy : MonoBehaviour
{
    public int cantidadDisminuir = 5;
    public float tiempo;
    public bool isAttacked = false;
    public bool isInvulnerable = false;
    CharacterController controller;




    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }


    private void Update()
    {
        tiempo += Time.deltaTime;

        //Debug.Log("timepo: " + tiempo);

        //Debug.Log(gameObject.transform.position.x + " :" + gameObject.transform.position.z);
    }

   

    IEnumerator Hit()
    {
        //put how many seconds you want it to wait in WaitForSeconds(here)
        isAttacked = true;
        //tiempo = 0;
        yield return new WaitForSeconds(0.7f);
        

        isAttacked = false;

       

    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(Hit());
            LivesManger.instance.disminuirVida(cantidadDisminuir);

            //Retroceder
            Vector3 distanciaRetroceder = new Vector3(0, 0, 1.5f);
            controller.Move(distanciaRetroceder);
        }
    }


}
