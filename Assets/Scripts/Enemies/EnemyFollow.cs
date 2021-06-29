using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;

    void Start()
    {
        enemy = gameObject.GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        enemy.SetDestination(player.position);
    }

}
