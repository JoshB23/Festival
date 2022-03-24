using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerZone : MonoBehaviour
{
    public GameObject player;
    public bool inTriggerZone;

   
    private void OnTriggerEnter(Collider other)
    {
        if (player)
        {
                
                inTriggerZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (player)
        {
            
            inTriggerZone = false;
        }
    }
}
