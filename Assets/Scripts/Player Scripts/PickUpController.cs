using UnityEngine;

public class PickUpController : MonoBehaviour
{
    public GameObject pickUpItem;

    public Rigidbody rb;
    public BoxCollider coll;
    public Transform player, holdPos, Cam;

    public float pickUpRange;
    public float dropForwardForce, dropUpwardForce;

    public bool isequipped;
    public static bool slotIsFull;

    

    private void Start()
    {
        // set up

        if (!isequipped)
        {
            // item script enabled
            rb.isKinematic = false;
            coll.isTrigger = false;

        }

        if (isequipped)
        {
            // item script enabled
            rb.isKinematic = true;
            coll.isTrigger = true;
            slotIsFull = true;
        }
    }
    private void Update()
    {
        // Check if Player is in range and Left Click is Pressed is pressed
        Vector3 distanceToPlayer = player.position - transform.position;
        if (!isequipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetMouseButtonDown(0) && slotIsFull) PickUp();

        // Drops weapon if equipped and right click is pressed
        if (isequipped && Input.GetMouseButtonDown(1)) Drop();
    }

    private void PickUp()
    {
        isequipped = true;
        slotIsFull = true;

        rb.isKinematic = true;
        coll.isTrigger = true;

        // enable item script

        // makes the weapon a child of the camera and move it to default position
        transform.SetParent(holdPos);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;


    }

    private void Drop()
    {
        isequipped = false;
        slotIsFull = false;

        // set parent to null
        transform.SetParent(null);

        rb.isKinematic = false;
        coll.isTrigger = false;

        

        // Object carries momentum of Player
        rb.linearVelocity = player.GetComponent<Rigidbody>().linearVelocity;

        // Adds Force to throw
        rb.AddForce(Cam.forward * dropForwardForce, ForceMode.Impulse);
        rb.AddForce(Cam.up * dropUpwardForce, ForceMode.Impulse);

        // Add random Rotation
        float random = Random.Range(-1f, 1f);
        rb.AddTorque(new Vector3(random, random, random) * 10);

        // disable item script
    }

}
