using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveCounter : MonoBehaviour
{
    [Header("Day 1 Objectives")]

    [SerializeField] private GameObject day1Obj1;
    [SerializeField] private GameObject day1Obj2;
    [SerializeField] private GameObject day1Obj3;

    private bool day1Obj1IsDone = false;
    private bool day1Obj2IsDone = false;
    private bool day1Obj3IsDone = false;

    TMP_Text day1Obj1text;
    TMP_Text day1Obj2text;
    TMP_Text day1Obj3text;

    [Header("Day 2 Objectives")]

    [SerializeField] private GameObject day2Obj1;
    [SerializeField] private GameObject day2Obj2;
    [SerializeField] private GameObject day2Obj3;

    private bool day2Obj1IsDone = false;
    private bool day2Obj2IsDone = false;
    private bool day2Obj3IsDone = false;

    TMP_Text day2Obj1text;
    TMP_Text day2Obj2text;
    TMP_Text day2Obj3text;

    [Header("Day 3 Objectives")]

    [SerializeField] private GameObject day3Obj1;
    [SerializeField] private GameObject day3Obj2;
    [SerializeField] private GameObject day3Obj3;
    [SerializeField] private GameObject day3Obj4;

    private bool day3Obj1IsDone = false;
    private bool day3Obj2IsDone = false;
    private bool day3Obj3IsDone = false;
    private bool day3Obj4IsDone = false;

    TMP_Text day3Obj1text;
    TMP_Text day3Obj2text;
    TMP_Text day3Obj3text;
    TMP_Text day3Obj4text;

    [Header("Day 4 Objectives")]

    [SerializeField] private GameObject day4Obj1;
    [SerializeField] private GameObject day4Obj2;

    private bool day4Obj1IsDone = false;
    private bool day4Obj2IsDone = false;
    private bool day4Obj3IsDone = false;

    TMP_Text day4Obj1text;
    TMP_Text day4Obj2text;
    TMP_Text day4Obj3text;

    [Header("Day 7 Objectives")]

    [SerializeField] private GameObject day7Obj1;
    [SerializeField] private GameObject day7Obj2;
    [SerializeField] private GameObject day7Obj3;
    [SerializeField] private GameObject day7Obj4;

    [Header("Day 8 Objectives")]

    [SerializeField] private GameObject day8Obj1;
    [SerializeField] private GameObject day8Obj2;
    [SerializeField] private GameObject day8Obj3;
    [SerializeField] private GameObject day8Obj4;

    [Header("Day by Day Headings")]

    [SerializeField] private GameObject day1All;
    [SerializeField] private GameObject day2All;
    [SerializeField] private GameObject day3All;
    [SerializeField] private GameObject day4All;
    [SerializeField] private GameObject day7All;
    [SerializeField] private GameObject day8All;

    [Header("script references")]
    [SerializeField] private DayCounter dayCounter;
    [SerializeField] private startdaycount startDayCount;


    [Header("Log off Button")]
    [SerializeField] private GameObject logOffButton;
    [SerializeField] private GameObject logOffReminder;

    [Header("day Specific Objects")]
    [SerializeField] private GameObject Friend1;
    [SerializeField] private GameObject Sheep1;
    [SerializeField] private GameObject Profile1;
    [SerializeField] private GameObject TaxesButton;
    [SerializeField] private GameObject noTaxes;
    [SerializeField] private GameObject policeAlert1;

    [SerializeField] private GameObject policeNotification;
    [SerializeField] private GameObject messageNotification;
    [SerializeField] private GameObject socialMediaNotification;
    [SerializeField] private GameObject taxesNotification;

    [Header("dialogue")]
    [SerializeField] private GameObject day3SheepDialogue;


    private void Start()
    {
        day1Obj1IsDone = false;
        day1Obj2IsDone = false;
        day1Obj3IsDone = false;

        day2Obj1IsDone = false;
        day2Obj2IsDone = false;
        day2Obj3IsDone = false;

        day3Obj1IsDone = false;
        day3Obj2IsDone = false;
        day3Obj3IsDone = false;
        day3Obj4IsDone = false;

        day4Obj1IsDone = false;
        day4Obj2IsDone = false;
        day4Obj3IsDone = false;

        logOffReminder.gameObject.SetActive(false); 

        Sheep1.gameObject.SetActive(false);
        Friend1.gameObject.SetActive(false);
        Profile1.gameObject.SetActive(false);

        noTaxes.gameObject.SetActive(true);
        policeAlert1.gameObject.SetActive(false);

        socialMediaNotification.gameObject.SetActive(false);
        policeNotification.gameObject.SetActive(false);

        messageNotification.gameObject.SetActive(true);
        
    }



private void Update()
    {
        if (dayCounter.dayCount == 1)
        {
            day1All.gameObject.SetActive(true);
        }

        if (dayCounter.dayCount == 2)
        {
            day1All.gameObject.SetActive(false);
            day2All.gameObject.SetActive(true);

            Profile1.gameObject.SetActive(true);
        }

        if (dayCounter.dayCount == 3)
        {
            day2All.gameObject.SetActive(false);
            day3All.gameObject.SetActive(true);

            Friend1.gameObject.SetActive(true);
        }

        if (dayCounter.dayCount == 4)
        {
            day3All.gameObject.SetActive(false);
            day4All.gameObject.SetActive(true);

        }

        if (dayCounter.dayCount == 7)
        {
            day4All.gameObject.SetActive(false);
            day7All.gameObject.SetActive(true);
        }

        if (dayCounter.dayCount == 8)
        {
            day7All.gameObject.SetActive(false);
            day8All.gameObject.SetActive(true);
        }

        if (dayCounter.dayCount == 1)
        {
            if (day1Obj1IsDone == true)
            {
                if (day1Obj2IsDone == true)
                {
                    if (day1Obj3IsDone == true)
                    {
                        logOffButton.gameObject.GetComponent<Button>().interactable = true;
                        logOffReminder.gameObject.SetActive(true);
                        // Play some kind of pinging SFX for Log off notification

                    }
                }

            }
        }

        if (dayCounter.dayCount == 2)
        {
            if (day2Obj1IsDone == true)
            {
                if (day2Obj2IsDone == true)
                {
                    if (day2Obj3IsDone == true)
                    {
                        logOffButton.gameObject.GetComponent<Button>().interactable = true;
                        logOffReminder.gameObject.SetActive(true);
                        // Play some kind of pinging SFX for Log off notification
                    }
                }

            }
        }

        if (dayCounter.dayCount == 3)
        {
            if (day3Obj1IsDone == true)
            {
                if (day3Obj2IsDone == true)
                {
                    if (day3Obj3IsDone == true)
                    {
                        if (day3Obj4IsDone)
                        {
                            logOffButton.gameObject.GetComponent<Button>().interactable = true;
                            logOffReminder.gameObject.SetActive(true);
                            // Play some kind of pinging SFX for Log off notification
                        }

                    }
                }

            }
        }

        if (dayCounter.dayCount == 4)
        {
            if (day4Obj1IsDone)
            {
                Sheep1.gameObject.SetActive(true);
            }
        }
    }

    public void d1o1complete()
    {
        if (dayCounter.dayCount == 1)
        {
            day1Obj1text = day1Obj1.gameObject.GetComponent<TMP_Text>();
            day1Obj1text.color = Color.green;
            day1Obj1IsDone = true;
        }
    }

    public void d1o2complete()
    {
        if (dayCounter.dayCount == 1)
        {
            day1Obj2text = day1Obj2.gameObject.GetComponent<TMP_Text>();
            day1Obj2text.color = Color.green;
            day1Obj2IsDone = true;
        }
    }

    public void d1o3complete()
    {
        if (dayCounter.dayCount == 1)
        {
            day1Obj3text = day1Obj3.gameObject.GetComponent<TMP_Text>();
            day1Obj3text.color = Color.green;
            day1Obj3IsDone = true;
        }
    }

    public void d2o1complete()
    {
        if (dayCounter.dayCount == 2)
        {
            day2Obj1text = day2Obj1.gameObject.GetComponent<TMP_Text>();
            day2Obj1text.color = Color.green;
            day2Obj1IsDone = true;
        }
    }

    public void d2o2complete()
    {
        if (dayCounter.dayCount == 2)
        {
            day2Obj2text = day2Obj2.gameObject.GetComponent<TMP_Text>();
            day2Obj2text.color = Color.green;
            day2Obj2IsDone = true;
        }
    }

    public void d2o3complete()
    {
        if (dayCounter.dayCount == 2)
        {
            day2Obj3text = day2Obj3.gameObject.GetComponent<TMP_Text>();
            day2Obj3text.color = Color.green;
            day2Obj3IsDone = true;
        }
    }

    public void d3o1complete()
    {
        if (dayCounter.dayCount == 3)
        {
            day3Obj1text = day3Obj1.gameObject.GetComponent<TMP_Text>();
            day3Obj1text.color = Color.green;
            day3Obj1IsDone = true;
        }
    }

    public void d3o2complete()
    {
        if (dayCounter.dayCount == 3)
        {
            day3Obj2text = day3Obj2.gameObject.GetComponent<TMP_Text>();
            day3Obj2text.color = Color.green;
            day3Obj2IsDone = true;
        }
    }

    public void d3o3complete()
    {
        if (dayCounter.dayCount == 3)
        {
            day3Obj3text = day3Obj3.gameObject.GetComponent<TMP_Text>();
            day3Obj3text.color = Color.green;
            day3Obj3IsDone = true;
        }
    }

    public void d3o4complete()
    {
        if (dayCounter.dayCount == 3)
        {
            day3Obj4text = day3Obj4.gameObject.GetComponent<TMP_Text>();
            day3Obj4text.color = Color.green;
            day3Obj4IsDone = true;
        }
    }

    public void d4o1complete()
    {
        if (dayCounter.dayCount == 4)
        {
            day4Obj1text = day4Obj1.gameObject.GetComponent<TMP_Text>();
            day4Obj1text.color = Color.green;
            day4Obj1IsDone = true;
        }
    }

    public void d4o2complete()
    {
        if (dayCounter.dayCount == 4)
        {
            day4Obj2text = day4Obj2.gameObject.GetComponent<TMP_Text>();
            day4Obj2text.color = Color.green;
            day4Obj2IsDone = true;
        }
    }

    public void d4o3complete()
    {
        day4Obj2text = day4Obj2.gameObject.GetComponent<TMP_Text>();
        day4Obj2text.color = Color.green;
        day4Obj3IsDone = true;
    }

    public void day1Complete()
    {
        if (dayCounter.dayCount == 1)
        {
            logOffButton.gameObject.GetComponent<Button>().interactable = false;
            logOffReminder.gameObject.SetActive(false);
            dayCounter.ChangeDay();
            startDayCount.ShowDate();
            // turn off pinging SFX
        }
    }

    public void day2Complete()
    {
        if (dayCounter.dayCount == 2)
        {
            dayCounter.ChangeDay();
            logOffButton.gameObject.GetComponent<Button>().interactable = false;
            logOffReminder.gameObject.SetActive(false);
            startDayCount.ShowDate();
            // turn off pinging SFX
        }
    }

    public void day3Complete()
    {
        if (dayCounter.dayCount == 3)
        {
            dayCounter.ChangeDay();
            logOffButton.gameObject.GetComponent<Button>().interactable = false;
            logOffReminder.gameObject.SetActive(false);
            startDayCount.ShowDate();
            day4Taxes();
            // turn off pinging SFX
        }

    }

    public void day4Complete()
    {
        if (dayCounter.dayCount == 4)
        {
            // sheep wail SFX goes here
            dayCounter.dayCount = 7;
            day3SheepDialogue.gameObject.SetActive(false);
            startDayCount.ShowDate();
        }

    }

    public void day2alert()
    {
        socialMediaNotification.gameObject.SetActive(true);
    }

    public void day4Taxes()
    {
        TaxesButton.gameObject.SetActive(true);
        noTaxes.gameObject.SetActive(false);
        taxesNotification.gameObject.SetActive(true);
    }

    public void PoliceAlert1()
    {
        policeAlert1.gameObject.SetActive(true);
        policeNotification.gameObject.SetActive(true);
    }
}
