using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySightScript : MonoBehaviour
{
    public bool playerInSight;
    public Transform player;
    public float walkingDistance = 10.0f;
    NavMeshAgent navMeshAgent;

    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if( playerInSight == true )
        {
            navMeshAgent.destination = player.position;
        }

        else
        {

        }
    }
}