using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionManager : MonoBehaviour
{
    public static PotionManager instance;

    public float tiempoActual;
    public float tiempoEspera = 5f;


    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        tiempoActual += Time.deltaTime;
    }
}
