using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DayCounter : MonoBehaviour
{

    public int dayCount;
    public TextMeshProUGUI computerDaycount; // this will be displayed on the computer 
    public TextMeshProUGUI mainUIDaycount; // this will be displayed within the main UI
    public TextMeshProUGUI loadingdayCount; // this is for the loading screen 

    public GameObject taxesButton;
    private bool taxesPaid;

    [SerializeField] MoneyManager moneyManager;

    [Header("Police Alert")]
    public GameObject day5Alert;
    public GameObject day10Alert;
    public GameObject day20Alert;
    public GameObject day25Alert;
    public GameObject day30Alert;
    public GameObject noAlerts;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dayCount = 01;
        computerDaycount.text = "Day:" + dayCount.ToString();
        mainUIDaycount.text = "Day:" + dayCount.ToString();
        loadingdayCount.text = "Day:" + dayCount.ToString(); // Paste this in everyday when there is a change in day count
        taxesPaid = true;

    }

    // Update is called once per frame
    void Update()
    {
        // keeps the day counter UI always updated 

        computerDaycount.text = "Day:" + dayCount.ToString();
        mainUIDaycount.text = "Day:" + dayCount.ToString();
        loadingdayCount.text = "Day:" + dayCount.ToString();

        if (taxesPaid = false && dayCount == 5 )
        {
            taxesPaid = false;
        }

        if (taxesPaid = false && dayCount == 10)
        {
            taxesPaid = false;
        }

        if (taxesPaid = false && dayCount == 15)
        {
            taxesPaid = false;
        }

        if (taxesPaid = false && dayCount == 20)
        {
            taxesPaid = false;
        }

        if (taxesPaid = false && dayCount == 25)
        {
            taxesPaid = false;
        }

        if (dayCount < 5 )
        {
            noAlerts.gameObject.SetActive(true);
            Debug.Log("Day 5");
        }
        else if (dayCount > 4)
        {
            noAlerts.gameObject.SetActive(false);
        }

        if (dayCount == 5)
        {
            day5Alert.gameObject.SetActive(true);
        }

        if (dayCount == 10)
        {
            day10Alert.gameObject.SetActive(true);
        }


        if (dayCount == 20)
        {
            day20Alert.gameObject.SetActive(true);
        }

        if (dayCount == 25)
        {
            day25Alert.gameObject.SetActive(true);
        }

        if (dayCount == 30)
        {
            day30Alert.gameObject.SetActive(true);
        }



        if (taxesPaid == false)
        {
            taxesButton.gameObject.GetComponent<Button>().interactable = true;
        }
        else if (taxesPaid == true)
        {
            taxesButton.gameObject.GetComponent<Button>().interactable = false;
        }

    }

    public void ChangeDay()
    {
        dayCount++;
    }

    public void payTaxes()
    {
        moneyManager.taxes();
        taxesPaid = true;
    }
}
