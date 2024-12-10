using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardParent : MonoBehaviour
{
    // maybe make this a haashset 
    //[SerializeField]
    //public List<GameObject> keycardsFound = new List<GameObject>();

    [SerializeField]
    private GameObject door;
    private bool doorOpen;

    public bool keycard1Pressed = false;
    public bool keycard2Pressed = false;
    public bool keycard3Pressed = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // can be a function on its own 

        if (keycard1Pressed && keycard2Pressed && keycard3Pressed)
        {
            OpenDoor();
        }
    }
    private void OpenDoor()
    {
        // doorOpen = !doorOpen
        doorOpen = true;
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
    }
}
