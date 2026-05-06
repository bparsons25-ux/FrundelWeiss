using UnityEngine;

public class CalendarManager : MonoBehaviour
{
    [SerializeField] private DayCounter dayCounter;

    public GameObject day1Checklist;
    public GameObject day2Checklist;
    public GameObject day3Checklist;
    public GameObject day4Checklist;
    public GameObject day7Checklist;

    private void Start()
    {
        
    }
    // Update is called once per frame
    private void Update()
    {
        if (dayCounter.dayCount == 1)
        {
            day1Checklist.gameObject.SetActive(true);

        }

        if (dayCounter.dayCount == 2)
        {
            day1Checklist.gameObject.SetActive(false);
            day2Checklist.gameObject.SetActive(true);
        }

        if (dayCounter.dayCount == 3)
        {
            day2Checklist.gameObject.SetActive(false);
            day3Checklist.gameObject.SetActive(true);
        }

        if (dayCounter.dayCount == 4)
        {
            day3Checklist.gameObject.SetActive(false);
            day4Checklist.gameObject.SetActive(true);
        }

        if (dayCounter.dayCount == 7)
        {
            day4Checklist.gameObject.SetActive(false);
            day7Checklist.gameObject.SetActive(true);
        }
    }
}
