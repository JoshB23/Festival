using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SwampEnemy : MonoBehaviour
{
    public EnemyTriggerZone enemyTriggerZone;
    public Transform player;
    int MoveSpeed = 4;
    public NavMeshAgent agent;

    public float attackDistance = 5;
    private Transform playerObject;

    private void Awake()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player").transform;

    }


    void Update()
    {
        if (enemyTriggerZone.inTriggerZone)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            agent.SetDestination(player.position);
        }
        else
        {
            agent.SetDestination(agent.transform.position);
        }

        if (Vector3.Distance(transform.position, playerObject.position) <= attackDistance)
        {
            FPSController.OnTakeDamage(100);

        }
    }
}
