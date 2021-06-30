using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBackgroundDead : MonoBehaviour
{


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("deadbackground"))
        {
            //Debug.Log("Colisono con el espacio");
            ManageScenes.instance.goToGameOver();
        }
    }

}
