using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionStar : MonoBehaviour
{



    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Star"))
        {
            Destroy(hit.gameObject);
        }
    }

}
