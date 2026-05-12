using UnityEngine;

public class sheepDestroyer : MonoBehaviour
{

    [SerializeField] private ObjectiveCounter counter;
    [SerializeField] private DayCounter dayCounter;
    [SerializeField] private PickUpRaycastScript pickUpRaycastScript;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Dead Sheep"))
        {
            Destroy(collision.gameObject);
            PickUpRaycastScript.canPickUp = true;

            if (dayCounter.dayCount == 8)
            {
                counter.d8o1complete();
            }
        }






    }


}
