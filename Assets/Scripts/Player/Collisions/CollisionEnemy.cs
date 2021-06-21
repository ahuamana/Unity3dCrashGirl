using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemy : MonoBehaviour
{
    public int cantidadDisminuir = 5;
    public float tiempo;
    public bool isAttacked = false;
    public bool isInvulnerable = false;
    Rigidbody rigidbody;




    private void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }


    private void Update()
    {
        tiempo += Time.deltaTime;

        //Debug.Log("timepo: " + tiempo);

    }

   

    IEnumerator Hit()
    {
        //put how many seconds you want it to wait in WaitForSeconds(here)
        isAttacked = true;
        //tiempo = 0;
        yield return new WaitForSeconds(0.7f);
        

        isAttacked = false;


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(Hit());
            LivesManger.instance.disminuirVida(cantidadDisminuir);

            //Retroceder
            rigidbody.AddForce(Vector3.forward, ForceMode.Impulse);
        }
    }


}
