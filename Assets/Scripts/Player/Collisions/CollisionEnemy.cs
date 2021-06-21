using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemy : MonoBehaviour
{
    public int cantidadDisminuir = 5;
    public float tiempo;
    public bool isAttacked = false;

   

    private void Update()
    {
        tiempo += Time.deltaTime;
        

    }

    IEnumerator Hit()
    {
        //put how many seconds you want it to wait in WaitForSeconds(here)
        yield return new WaitForSeconds(0.7f);
        tiempo = 0;
        isAttacked = false;
        Debug.Log("timepo: "+ tiempo);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && tiempo >= 0.7f)
        {
            isAttacked = true;
            StartCoroutine(Hit());
        }
    }


}
