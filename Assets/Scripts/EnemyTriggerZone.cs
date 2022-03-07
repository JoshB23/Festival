using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerZone : MonoBehaviour
{
    public AudioSource alert;
    public GameObject player;
    public bool inTriggerZone;

    private void Start()
    {
        alert = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (player)
        {
                alert.Play(0);
                inTriggerZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (player)
        {
            alert.Pause();
            inTriggerZone = false;
        }
    }
}
