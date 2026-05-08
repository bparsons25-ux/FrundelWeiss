using System.Collections;
using UnityEngine;

public class Day3Ending : MonoBehaviour
{
    [SerializeField] private GameObject transition;
    [SerializeField] private ObjectiveCounter ObjectiveCounter;


    private float transitionTime = 5f;

    private void Start()
    {
        ObjectiveCounter.gameObject.SetActive(false);
    }

    public void Day4transition()
    {
        StartCoroutine(D4trans());
    }

    IEnumerator D4trans()
    {
        transition.gameObject.SetActive(true);
        yield return new WaitForSeconds(transitionTime);
        ObjectiveCounter.day4Complete();


    }


}
