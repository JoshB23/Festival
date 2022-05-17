using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTriggerAttack : MonoBehaviour
{
    public TouchingGrass touchingGrass;
    public Transform player;
    int MoveSpeed = 4;
    public NavMeshAgent agent;

    public float attackDistance = 5;
    private Transform playerObject;

    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;

    private void Awake()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        if (touchingGrass.isTouchingGrass)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            agent.SetDestination(player.position);
        }
        else
        {
            target = waypoints[waypointIndex].position;
            agent.SetDestination(target);

            if (Vector3.Distance(transform.position, target) < 1)
            {
                IterateWaypointIndex();
            }
        }

        if (Vector3.Distance(transform.position, playerObject.position) <= attackDistance)
        {
            FPSController.OnTakeDamage(100);

        }
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
}
