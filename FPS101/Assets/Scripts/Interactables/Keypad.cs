using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //this function is where we will design out interaction using code
    protected override void Interact()
    {
        Debug.Log("Interact with " + gameObject.name);
    }
}
