using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Interactable
{
    public Material myMaterialOne;
    public bool on;

    public void Awake()
    {
        on = false;
        myMaterialOne.color = Color.red;
    }

    public override void OnFocus()
    {
        print("LOOKING AT " + gameObject.name);
    }

    public override void OnInteract()
    {
        print("INTERACTED WITH " + gameObject.name);
        on = true;
        myMaterialOne.color = Color.green;
    }

    public override void OnLoseFocus()
    {
        print("STOPPED LOOKING AT " + gameObject.name);
    }

}
