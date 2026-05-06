using UnityEngine;

public class ObjectiveCounter : MonoBehaviour
{
    [Header("Day 1 Objectives")]

    [SerializeField] private GameObject day1obj1;
    [SerializeField] private GameObject day1obj2;
    [SerializeField] private GameObject day1obj3;

    [Header("Day 2 Objectives")]

    [SerializeField] private GameObject day2obj1;
    [SerializeField] private GameObject day2obj2;
    [SerializeField] private GameObject day2obj3;

    [Header("Day 3 Objectives")]

    [SerializeField] private GameObject day3obj1;
    [SerializeField] private GameObject day3obj2;
    [SerializeField] private GameObject day3obj3;
    [SerializeField] private GameObject day3obj4;

    [Header("Day 4 Objectives")]

    [SerializeField] private GameObject day4obj1;
    [SerializeField] private GameObject day4obj2;

    [Header("Day 7 Objectives")]

    [SerializeField] private GameObject day7obj1;
    [SerializeField] private GameObject day7obj2;
    [SerializeField] private GameObject day7obj3;
    [SerializeField] private GameObject day7obj4;

    [Header("Day 8 Objectives")]

    [SerializeField] private GameObject day8obj1;
    [SerializeField] private GameObject day8obj2;
    [SerializeField] private GameObject day8obj3;
    [SerializeField] private GameObject day8obj4;

    [Header("Day by Day Headings")]

    [SerializeField] private GameObject day1all;
    [SerializeField] private GameObject day2all;
    [SerializeField] private GameObject day3all;
    [SerializeField] private GameObject day4all;
    [SerializeField] private GameObject day7all;
    [SerializeField] private GameObject day8all;

    [Header("script references")]
    [SerializeField] private DayCounter dayCounter;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (dayCounter.dayCount == 1)
        {
            day1all.gameObject.SetActive(true);
        }

        if (dayCounter.dayCount == 2)
        {
            day1all.gameObject.SetActive(false);
            day2all.gameObject.SetActive(true);
        }

        if (dayCounter.dayCount == 3)
        {
            day2all.gameObject.SetActive(false);
            day3all.gameObject.SetActive(true);
        }

        if (dayCounter.dayCount == 4)
        {
            day3all.gameObject.SetActive(false);
            day4all.gameObject.SetActive(true);
        }

        if (dayCounter.dayCount == 7)
        {
            day4all.gameObject.SetActive(false);
            day7all.gameObject.SetActive(true);
        }

        if (dayCounter.dayCount == 8)
        {
            day7all.gameObject.SetActive(false);
            day8all.gameObject.SetActive(true);
        }
    }

}
