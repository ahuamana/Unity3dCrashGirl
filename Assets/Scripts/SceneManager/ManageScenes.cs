using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    public String  escenaInicio = "InicioEscena";
    public String  escenaCreditos = "InicioEscena";

    public void goToInicio()
    {
        SceneManager.LoadScene(escenaInicio);
    }

    public void goToCreditos()
    {
        SceneManager.LoadScene(escenaCreditos);
    }
}
