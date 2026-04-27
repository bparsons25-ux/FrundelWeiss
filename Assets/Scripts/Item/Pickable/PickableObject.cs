using UnityEngine;

public class PickableObject : MonoBehaviour, IPckable
{

    [field: SerializeField]

    public bool KeepWorldPosition { get; private set; } = true;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public GameObject PickUp()
    { 
        if (rb != null)
        {
            rb.isKinematic = true;
        }

        return gameObject;
    }

}
