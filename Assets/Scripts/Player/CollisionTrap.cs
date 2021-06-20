using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionTrap : MonoBehaviour
{

    public bool playerDentro = false;
    public int cantidadADisminuir = 10;
    public float time;
    public float tiempopoEsperaParaAtaque = 0.5f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            
            //Debug.Log("colisiono with trap");
            playerDentro = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            //Debug.Log("salio de la trampa");
            playerDentro = false;
        }

    }

    private void Update()
    {
        

        if (LivesManger.instance.tiempo >= tiempopoEsperaParaAtaque && playerDentro)
        {
            LivesManger.instance.tiempo = 0;
            LivesManger.instance.disminuirVida(cantidadADisminuir);
        }
    }





}
