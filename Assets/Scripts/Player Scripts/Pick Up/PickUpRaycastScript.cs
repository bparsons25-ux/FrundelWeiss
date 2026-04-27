using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpRaycastScript : MonoBehaviour
{
    [SerializeField] private LayerMask movableLayerMask;

    [SerializeField] private Transform playerCamTransform;

    [SerializeField] private GameObject pickUpUI;

    [SerializeField][Min(1)] private float hitRange;

    [SerializeField] private Transform pickUpParent;

    [SerializeField] private GameObject inHandItem;





    private RaycastHit hit;


    private void Update()
    {
        Debug.DrawRay(playerCamTransform.position, playerCamTransform.forward * hitRange, Color.red);
        if (hit.collider != null)
        {
            hit.collider.GetComponent<Highlight>()?.ToggleHighlight(false);
            pickUpUI.SetActive(false);
        }

        if (inHandItem != null)
        {
            return;
        }

        if (Physics.Raycast(playerCamTransform.position, playerCamTransform.forward, out hit, hitRange, movableLayerMask))
        {
            hit.collider.GetComponent<Highlight>()?.ToggleHighlight(true);
            pickUpUI.SetActive(true);
        }


    }

    public void PickUp()
    {
        if(hit.collider != null)
        {

            //IPckable pickableItem = hit.collider.GetComponent<IPckable>();
            //if (pickableItem != null )
            //{
            //    Debug.Log("Picked Up");
            //    inHandItem = pickableItem.PickUp();
            //    inHandItem.transform.SetParent(pickUpParent.transform, pickableItem.KeepWorldPosition);
            //}

            Debug.Log(hit.collider.name);
            Rigidbody rb = hit.collider.GetComponent<Rigidbody>();
            if (hit.collider.GetComponent<Item>()) // close up hand held 
            {
                Debug.Log("It's food!");

                inHandItem = hit.collider.gameObject;
                inHandItem.transform.position = Vector3.zero;
                inHandItem.transform.rotation = Quaternion.identity;
                inHandItem.transform.SetParent(pickUpParent.transform, false);

                if (rb != null)
                {
                    rb.isKinematic = true;
                }

                return;
            }

            if (hit.collider.GetComponent<Handheld>()) // far away moving hold
            {
                Debug.Log("Bosh it's a Jar...");
                inHandItem = hit.collider.gameObject;
                inHandItem.transform.SetParent(pickUpParent.transform, true);
                if (rb != null)
                {
                    rb.isKinematic = true;
                }
                return;
            }
        }
    }

    public void Drop()
    {
        if (inHandItem != null)
        {
            inHandItem.transform.SetParent(null);
            inHandItem = null;
            Rigidbody rb = hit.collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
            }
        }
    }

    public void Use()
    {
        
    }


}
