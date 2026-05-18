using System.Collections;
using UnityEngine;

public class Day3Ending : MonoBehaviour
{
    [SerializeField] private GameObject transition;
    [SerializeField] private ObjectiveCounter ObjectiveCounter;

    [SerializeField] private DayCounter dayCounter;


    private float transitionTime = 5f;

    private void Start()
    {
        transition.gameObject.SetActive(false);
    }

    public void Day4transition()
    {
        StartCoroutine(D4trans());
    }

    IEnumerator D4trans()
    {
        transition.gameObject.SetActive(true);
        yield return new WaitForSeconds(transitionTime);

        if (dayCounter.dayCount == 4)
        {
            ObjectiveCounter.day4Complete();
        }

        if (dayCounter.dayCount == 17)
        {
            ObjectiveCounter.day17Complete();
        }

        if (dayCounter.dayCount == 33)
        {
            // ObjectiveCounter.day33Complete();
        }

        if (dayCounter.dayCount == 45)
        {
            // ObjectiveCounter.day45Complete();
        }

        transition.gameObject.SetActive(false);
    }


}
