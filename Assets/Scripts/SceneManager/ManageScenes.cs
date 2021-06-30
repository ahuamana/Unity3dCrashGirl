using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    public static ManageScenes instance;

    public String  escenaInicio = "InicioEscena";
    public String  escenaCreditos = "Creditos";
    public String  escenaGameOver = "GameOver";


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }



    public void goToInicio()
    {
        SceneManager.LoadScene(escenaInicio);
    }

    public void goToCreditos()
    {
        SceneManager.LoadScene(escenaCreditos);
    }

    public void goToGameOver()
    {
        SceneManager.LoadScene(escenaGameOver);
    }

}
