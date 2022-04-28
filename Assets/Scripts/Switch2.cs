using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch2 : Interactable
{
    public Material myMaterialTwo;
    public bool on;

    public void Awake()
    {
        on = false;
        myMaterialTwo.color = Color.red;
    }

    public override void OnFocus()
    {
        print("LOOKING AT " + gameObject.name);
    }

    public override void OnInteract()
    {
        print("INTERACTED WITH " + gameObject.name);
        on = true;
        myMaterialTwo.color = Color.green;
    }

    public override void OnLoseFocus()
    {
        print("STOPPED LOOKING AT " + gameObject.name);
    }

}
