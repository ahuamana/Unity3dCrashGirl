using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverData : MonoBehaviour
{
    // Start is called before the first frame update

    public Text points;

    void Start()
    {
        
        points.text=StarManager.instance.cantidadEstrellas + " POINTS";
    }

   
}
