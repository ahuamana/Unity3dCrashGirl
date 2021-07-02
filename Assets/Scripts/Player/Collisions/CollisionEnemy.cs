using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemy : MonoBehaviour
{
    public int cantidadDisminuir = 5;
    public float tiempo;
    public bool isAttacked = false;
    public bool isInvulnerable = false;
    CharacterController controller;

    public Material[] materials;
    Renderer renderer;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        renderer = gameObject.GetComponent<Renderer>();
        renderer.enabled = true;
    }


    private void Update()
    {
        tiempo += Time.deltaTime;
    }

   

    IEnumerator Hit()
    {
        //put how many seconds you want it to wait in WaitForSeconds(here)
        isAttacked = true;
        //tiempo = 0;

        renderer.sharedMaterial = materials[1];
        yield return new WaitForSeconds(0.7f);
        renderer.sharedMaterial = materials[0];

        isAttacked = false;

       

    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.gameObject.CompareTag("Enemy"))
        {

            if (LivesManger.instance.vidaActual <= 0)
            {
                ManageScenes.instance.goToGameOver();
            }

            StartCoroutine(Hit());
            LivesManger.instance.disminuirVida(cantidadDisminuir);


            //Retroceder
            //Vector3 distanciaRetroceder = new Vector3(0, 0, 1.5f);
            //controller.Move(distanciaRetroceder);
        }
    }


}
