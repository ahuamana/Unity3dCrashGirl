using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerDragonTiny : MonoBehaviour
{
    Animator anim;
    
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetTrigger("Attack 01");
    }
}
