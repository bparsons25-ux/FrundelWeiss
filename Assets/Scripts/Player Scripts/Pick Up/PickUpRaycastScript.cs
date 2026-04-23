using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpRaycastScript : MonoBehaviour
{
    [SerializeField] private LayerMask movableLayerMask;

    [SerializeField] private Transform playerCamTransform;

    [SerializeField] private GameObject pickUpUI;

    [SerializeField][Min(1)] private float hitRange;


    private RaycastHit hit;


    private void Update()
    {
        Debug.DrawRay(playerCamTransform.position, playerCamTransform.forward * hitRange, Color.red);
        if (hit.collider != null)
        {
            hit.collider.GetComponent<Highlight>()?.ToggleHighlight(false);
            pickUpUI.SetActive(false);
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
        }
    }

    public void Drop()
    {
        
    }

    public void Use()
    {
        
    }


}
