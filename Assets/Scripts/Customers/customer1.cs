using UnityEngine;

public class customer1 : MonoBehaviour
{
    [SerializeField] private ObjectiveCounter counter;
    [SerializeField] private GeneralFunctions generalFunctions;

    [SerializeField] private WaypointMovement waypointMovement;
    [SerializeField] private GoHomeWaypointMovement goHomeWaypointMovement;

    [SerializeField] CustomerOrderCountdown customerOrderCountdown;
    [SerializeField] private GameObject customerCountDown;

    [SerializeField] private GameObject heartJar;

    private void Start()
    {
        customerCountDown.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Heart Jar"))
        {
            counter.d8o4complete();
        }
    }

}
