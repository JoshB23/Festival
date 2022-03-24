using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchingGrass : MonoBehaviour
{
    public bool isTouchingGrass;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            isTouchingGrass = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            isTouchingGrass = false;
        }
    }
}
