using UnityEngine;

public class sheepDestroyer : MonoBehaviour
{

    [SerializeField] private ObjectiveCounter counter;
    [SerializeField] private DayCounter dayCounter;

    private void OnTriggerEnter(Collider collision)
    {
        if (dayCounter.dayCount == 8 && collision.CompareTag("Dead Sheep"))
        {
            counter.d8o1complete();
        }

    }


}
