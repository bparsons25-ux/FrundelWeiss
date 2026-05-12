using UnityEngine;

public class customer1 : MonoBehaviour
{
    [SerializeField] private ObjectiveCounter counter;
    [SerializeField] private GeneralFunctions generalFunctions;
    [SerializeField] private DayCounter dayCounter;

    [SerializeField] private WaypointMovement waypointMovement;
    [SerializeField] private PickUpRaycastScript pickUpRaycastScript;

    [SerializeField] private CustomerOrderCountdown orderCountdown;
    [SerializeField] private GameObject customerCountdownObject;


    [SerializeField] CustomerOrderCountdown customerOrderCountdown;
    [SerializeField] private GameObject customerCountDown;

    private void Start()
    {
        customerCountDown.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (dayCounter.dayCount == 8)
        {
            if (collision.CompareTag("Heart Jar") && orderCountdown.remainingTime > 0)
            {
                counter.d8o4complete();
                Destroy(collision.gameObject);
                PickUpRaycastScript.canPickUp = true;
                orderCountdown.remainingTime = 120;
                customerCountDown.gameObject.SetActive(false);

            }
        }
    }

}
