using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aumentarVida : MonoBehaviour
{
    public float tiempoDeEspera = 5;
    string objeto;
    public GameObject objecto;

    

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Vida"))
        {
            LivesManger.instance.aumentarVida();
            hit.gameObject.SetActive(false); //ocultar vida
            LivesManger.instance.tiempoVida = 0;
            objecto = hit.gameObject;

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
