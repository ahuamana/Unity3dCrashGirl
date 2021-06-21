using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionStar : MonoBehaviour
{
    public float cantidadRecolectada = 10;


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Star"))
        {
            Destroy(hit.gameObject);
            StarManager.instance.recolectarMonedas(cantidadRecolectada);
        }
    }

}
