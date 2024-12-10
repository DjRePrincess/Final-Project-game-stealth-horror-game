using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // add or remove an InteractionEvent component to this gameobject 
    public bool useEvents;
    [SerializeField]
    public string interactablePromptMessage;

    // public virtual string OnLook()


    // will be called from our player script / template method pattern
    public void BaseInteract()
    {
        if (useEvents)
        {
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        }
        Interact();
    }
    
    protected virtual void Interact()
    {
        // template function to be overridden by our subclasses 
    }
}
