using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitches : MonoBehaviour
{
    public Switch switchOne;
    public Switch2 switchTwo;
    public Switch3 switchThree;

    public bool isOpen;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (switchOne.on && switchTwo.on && switchThree.on)
        {
            isOpen = true;
        }
        if (isOpen)
        {
            anim.SetBool("isOpen", isOpen);
        }
    }
}
