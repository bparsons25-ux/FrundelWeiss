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
            Debug.Log(hit.collider.name);
            if (hit.collider.GetComponent<Organ>())
            {
                Debug.Log("It's a Organ Mate...");
                inHandItem = hit.collider.gameObject;
                inHandItem.transform.position = Vector3.zero;
                inHandItem.transform.rotation = Quaternion.identity;
                inHandItem.transform.SetParent(pickUpParent.transform, false);
            }
        }
    }

    public void Drop()
    {
        
    }

    public void Use()
    {
        
    }


}
