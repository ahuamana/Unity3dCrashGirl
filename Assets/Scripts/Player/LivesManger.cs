using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManger : MonoBehaviour
{
    public static LivesManger instance;
    public int vidaInicial;
    public int vidaActual;
    public Slider barraVida;

    public float tiempo;
    public float tiempoVida;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        vidaInicial = 100;
        vidaActual = vidaInicial;
        barraVida.value = vidaActual;
    }

    public void disminuirVida(int cantidad)
    {
        if (vidaActual > 0)
        {
            vidaActual -= cantidad;
        }

        barraVida.value = vidaActual;

    }

    public void aumentarVida()
    {
        if (vidaActual < 100)
        {
            vidaActual = 100;
        }

        barraVida.value = vidaActual;

    }

    private void Update()
    {
        tiempo += Time.deltaTime;
        tiempoVida += Time.deltaTime;
    }

}
