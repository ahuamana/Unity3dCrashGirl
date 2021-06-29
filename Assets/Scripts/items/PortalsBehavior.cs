using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalsBehavior : MonoBehaviour
{

    ParticleSystem particle;

    void Start()
    {
        particle=gameObject.GetComponent<ParticleSystem>();
        particle.Stop();
    }

    

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colisono con el el portal");
            particle.Play();
        }
    }
}
