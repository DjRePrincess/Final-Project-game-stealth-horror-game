using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// this is actually not needed since we'll have 3 keycards scattered and that will unlock the door 

public class KeyCard1 : Interactable
{

    public KeycardParent keycardParent;
    public GameObject keycard1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    protected override void Interact()
    {
        

        Destroy(keycard1);

        keycardParent.keycard1Pressed = true;
        Debug.Log(keycardParent.keycard1Pressed);

    }

    ////////////////// can make keycardsFound a hashset later 
    // what if i just make a list named KeyCardsFound[] , add keycard object there if the player interacted(bool) 
    // function that checks if the list KeyCardsFound[] have like a length of 3 (primitive we are not actually checking if this is the right gameObjects)
}
// make sure interactable object is in 6:Interactable layer

// will just have an object near the door that says # out of 3 unlocked keypads 
