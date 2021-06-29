using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyOrcBehavior : MonoBehaviour
{

    NavMeshAgent agent;
    Animator anim;

    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", agent.speed);
        //Debug.Log(agent.speed.ToString());
    }
}
