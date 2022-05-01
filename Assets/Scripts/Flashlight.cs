using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : Interactable
{
    public Transform flashlightTransform;
    public GameObject flashlight;
    public bool equipped;
    public GameObject flashlightLight;
    public bool lightActive;
    public override void OnFocus()
    {
        print("LOOKING AT " + gameObject.name);
    }

    public override void OnInteract()
    {
        flashlight.transform.position = flashlightTransform.position;
        flashlight.transform.parent = flashlightTransform;
        flashlight.transform.localEulerAngles = new Vector3(0f, 180f, 0f);
        flashlight.GetComponent<Rigidbody>().isKinematic = true;
        equipped = true;
    }

    public override void OnLoseFocus()
    {
        print("STOPPED LOOKING AT " + gameObject.name);
    }

    private void Start()
    {
        flashlightLight.SetActive(true);
        lightActive = true;
    }
    private void Update()
    {
        if (equipped && Input.GetKeyDown(KeyCode.F))
        {
            if (lightActive == false)
            {
                flashlightLight.SetActive(true);
                lightActive = true;
            }
            else
            {
                flashlightLight.SetActive(false);
                lightActive = false;
            }
        }
    }

}
