using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject player;
    public Transform HoldPos;
    private InputManager InputManager;

    public float throwForce = 500f;
    public float pickUpRange = 5f;

    private GameObject heldObj;
    private Rigidbody heldObjRb;

    private bool canDrop = true;
    private int LayerNumber;

    private void Start()
    {
        InputManager = GetComponent<InputManager>();
        LayerNumber = LayerMask.NameToLayer("HoldLayer");
        
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (heldObj == null)
            {
                // perform raycasts to check if player is looking at object within pickup range
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange))
                {
                    // make sure pick up tag is attached
                    if (hit.transform.gameObject.tag == "MovableObject")
                    {
                        // pass in object hit into the PickUpObject function
                        PickUpObject(hit.transform.gameObject);
                    }
                }
            }
            else
            {
                if (canDrop == true)
                {
                    StopClipping(); // prevents object from clipping through walls
                    DropObject();
                }
            }
        }

        if (heldObj != null)
        {
            MoveObject();

            if(Input.GetMouseButton(1) && canDrop == true)
            {
                StopClipping();
                ThrowObject();
            }
        }
    }

    public void PickUpObject(GameObject pickUpObj)
    {
        if (pickUpObj.GetComponent<Rigidbody>()) // makes sure the object has a rigidbody
        {
            heldObj = pickUpObj;
            heldObjRb = pickUpObj.GetComponent<Rigidbody>();
            heldObjRb.isKinematic = true;
            heldObjRb.transform.parent = HoldPos.transform; // parent obj to holdpos (In Camera)
            heldObj.layer = LayerNumber; // changes the objects layer to the hold Layer

            Physics.IgnoreCollision(heldObj.GetComponent<Collider>(), player.GetComponent<Collider>(), true); // makes sure the object does not collide with the player

        }
    }

    public void DropObject()
    {
        // re-enable collision with the player
        Physics.IgnoreCollision(heldObj.GetComponent<Collider>(), player.GetComponent<Collider>(), false);
        heldObj.layer = 0;
        heldObjRb.isKinematic= false;
        heldObj.transform.parent = null; // 
        heldObj = null; // undefine game object
    }

    public void MoveObject()
    {
        heldObj.transform.position = HoldPos.transform.position;
    }

    public void ThrowObject()
    {
        Physics.IgnoreCollision(heldObj.GetComponent<Collider>(), player.GetComponent<Collider>(), false );
        heldObj.layer= 0;
        heldObjRb.isKinematic = false;
        heldObj.transform.parent = null;
        heldObjRb.AddForce(transform.forward * throwForce);
        heldObj = null;

    }

    public void StopClipping() // function only called when dropping / throwing
    {
        var clipRange = Vector3.Distance(heldObj.transform.position, transform.position); // distance from holdPos to the camera

        //have to use RaycastAll as object blocks raycast in center screen
        //RaycastAll returns array of all colliders hit within the cliprange

        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.TransformDirection(Vector3.forward), clipRange);

        if (hits.Length > 1)
        {
            //change object position to camera position 
            heldObj.transform.position = transform.position + new Vector3(0f, -0.5f, 0f);
            //if your player is small, change the -0.5f to a smaller number (in magnitude) ie: -0.1f
        }
    }


}
