using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // message which is displayed to the player when looking at an interactable
    public string promptMessage;

    // this function will be called from our player;
    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        // template function to be overridden by our sub classes

    }

}
