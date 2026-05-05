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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dayCount = 01;
        computerDaycount.text = "Day:" + dayCount.ToString();
        mainUIDaycount.text = "Day:" + dayCount.ToString();
        loadingdayCount.text = "Day:" + dayCount.ToString(); // Paste this in everyday when there is a change in day count

    }

    // Update is called once per frame
    void Update()
    {
        // keeps the day counter UI always updated 

        computerDaycount.text = "Day:" + dayCount.ToString();
        mainUIDaycount.text = "Day:" + dayCount.ToString();
        loadingdayCount.text = "Day:" + dayCount.ToString();

    }

    public void ChangeDay()
    {
        dayCount++;

    }
}
