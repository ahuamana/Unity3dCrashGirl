using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarManager : MonoBehaviour
{

    public float cantidadEstrellas = 0;
    public static StarManager instance;

    public Text estrellasTexto;

    private void Awake()
    {
        if (instance == null)
        {
            instance=this;
        }
        
    }


    public void recolectarMonedas(float estrellasRecogidas)
    {
        cantidadEstrellas += estrellasRecogidas;
        estrellasTexto.text = cantidadEstrellas.ToString()+ " Estrellas" ;

        PlayerPrefs.SetFloat("estrellasTotales", cantidadEstrellas);//Guardar monedas totales a nivel global

    }

}
