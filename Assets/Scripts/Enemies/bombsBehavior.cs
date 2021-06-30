using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombsBehavior : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Colisiono con enemigo");
            Destroy(collision.gameObject, 1.0f);
            Destroy(gameObject);
        }
    }

   
}
