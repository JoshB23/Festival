using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTriggerAttack : MonoBehaviour
{
    public EnemyTriggerZone enemyTriggerZone;
    public Transform player;
    int MoveSpeed = 4;
    public NavMeshAgent agent;

    void Start()
    {
       
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
    }
}
