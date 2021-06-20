using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aumentarVida : MonoBehaviour
{
    public float tiempoDeEspera = 5;
    string objeto;
    public GameObject objecto;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Vida"))
        {
            LivesManger.instance.aumentarVida();
            collision.gameObject.SetActive(false); //ocultar vida
            LivesManger.instance.tiempoVida = 0;
            objecto = collision.gameObject;

        }


    }

    void Update()
    {

        if (LivesManger.instance.tiempoVida >= tiempoDeEspera)
        {
            LivesManger.instance.tiempoVida = 0;

            if (objecto != null)
            {
                objecto.SetActive(true);
                Debug.Log("activando");
            }
            
            
        }

        

    }
}
