using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WeepingAngel : MonoBehaviour
{
    private Transform playerObject;

    public float speed = 5;

    public MeshRenderer angel;

    public float damage = 100;

    public float attackDistance = 5;
    public float startRange = 70;

    public NavMeshAgent agent;
    public WeepingAngelZone WeepingAngelZone;



    private void Awake()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player").transform;

    }

    bool PlayerNotLooking()
    {
        return !angel.isVisible;
    }

    private void Update()
    {
        if (PlayerNotLooking())
        {
            Move();
        }
        else
        {
            Stop();
        }

        if (Vector3.Distance(transform.position, playerObject.position) <= attackDistance)
        {
            FPSController.OnTakeDamage(100);

        }

    }

    private void Move()
    {
        if (playerObject && WeepingAngelZone.inTriggerZone) //&& (Vector3.Distance(transform.position, playerObject.position) <= startRange))
        {
            //transform.position += (playerObject.position - transform.position).normalized * speed * Time.deltaTime;

            agent.SetDestination(playerObject.position);

            Vector3 lookPos = playerObject.position - transform.position;
            lookPos.y = 0;
            transform.rotation = Quaternion.LookRotation(lookPos);
        }
        
    }

    private void Stop()
    {
        agent.SetDestination(agent.transform.position);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, startRange);
    }

}
