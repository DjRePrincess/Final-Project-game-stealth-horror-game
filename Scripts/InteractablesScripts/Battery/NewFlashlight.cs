using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewFlashlight : MonoBehaviour
{
    //private Stack<>
    Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            light.enabled = !light.enabled;
        }
    }
}
