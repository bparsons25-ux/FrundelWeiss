using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public bool useEvents; // Add or Remove InteractionEvent to this gameobject.

    // message which is displayed to the player when looking at an interactable
    [SerializeField] public string promptMessage;

    // this function will be called from our player;
    public void BaseInteract()
    {
        if ( useEvents)
        {
            GetComponent<interactionEvents>().OnInteract.Invoke();
        }
        Interact();
    }

    protected virtual void Interact()
    {
        // template function to be overridden by our sub classes
        // No code here called from base interactable script
        // any custom code will go inside of this method in our inhertited script;

    }

}
