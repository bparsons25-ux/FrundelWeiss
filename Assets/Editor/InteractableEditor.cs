using UnityEditor;


[CustomEditor(typeof(Interactable),true)]

public class InteractableEditor : Editor
{

    public override void OnInspectorGUI()
    {
        Interactable interactable = (Interactable)target;
        if (target.GetType() == typeof(EventOnlyInteractable))
        {
            interactable.promptMessage = EditorGUILayout.TextField("Prompt Message", interactable.promptMessage);
            EditorGUILayout.HelpBox("EventOnlyInteract can ONLY use UnityEvents", MessageType.Info);
            if(interactable.GetComponent<interactionEvents>() == null)
            {
                interactable.useEvents = true;
                interactable.gameObject.AddComponent<interactionEvents>();
            }
        }
        else
        {
            base.OnInspectorGUI();
            if (interactable.useEvents)
            {
                // using events. adds the component
                if (interactable.GetComponent<interactionEvents>() == null)
                {
                    interactable.gameObject.AddComponent<interactionEvents>();

                }
            }

            else
            {
                // NOT using events. Remove the components.
                if (interactable.GetComponent<interactionEvents>() != null)
                {
                    DestroyImmediate(interactable.GetComponent<interactionEvents>());
                }
            }
        }

    }

}
