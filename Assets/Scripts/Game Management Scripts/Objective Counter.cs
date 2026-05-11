using System.Collections;
using System.Runtime.CompilerServices;
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
    [SerializeField] private GameObject day4Obj3;

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

    private bool day7Obj1IsDone = false;
    private bool day7Obj2IsDone = false;
    private bool day7Obj3IsDone = false;
    private bool day7Obj4IsDone = false;

    TMP_Text day7Obj1text;
    TMP_Text day7Obj2text;
    TMP_Text day7Obj3text;
    TMP_Text day7Obj4text;

    [Header("Day 8 Objectives")]

    [SerializeField] private GameObject day8Obj1;
    [SerializeField] private GameObject day8Obj2;
    [SerializeField] private GameObject day8Obj3;
    [SerializeField] private GameObject day8Obj4;

    private bool day8Obj1IsDone = false;
    private bool day8Obj2IsDone = false;
    private bool day8Obj3IsDone = false;
    private bool day8Obj4IsDone = false;

    TMP_Text day8Obj1text;
    TMP_Text day8Obj2text;
    TMP_Text day8Obj3text;
    TMP_Text day8Obj4text;

    [Header("Day 10 Objectives")]

    [SerializeField] private GameObject day10Obj1;
    [SerializeField] private GameObject day10Obj2;

    private bool day10Obj1IsDone = false;
    private bool day10Obj2IsDone = false;

    TMP_Text day10Obj1text;
    TMP_Text day10Obj2text;

    [Header("Week 2, Day 1 Objectives")]

    [SerializeField] private GameObject w2day1Obj1;
    [SerializeField] private GameObject w2day1Obj2;
    [SerializeField] private GameObject w2day1Obj3;

    private bool w2day1Obj1IsDone = false;
    private bool w2day1Obj2IsDone = false;
    private bool w2day1Obj3IsDone = false;

    TMP_Text w2day1Obj1text;
    TMP_Text w2day1Obj2text;
    TMP_Text w2day1Obj3text;

    [Header("Week 2, Day 2 Objectives")]

    [SerializeField] private GameObject w2day2Obj1;
    [SerializeField] private GameObject w2day2Obj2;
    [SerializeField] private GameObject w2day2Obj3;

    private bool w2day2Obj1IsDone = false;
    private bool w2day2Obj2IsDone = false;
    private bool w2day2Obj3IsDone = false;

    TMP_Text w2day2Obj1text;
    TMP_Text w2day2Obj2text;
    TMP_Text w2day2Obj3text;

    [Header("Week 2, Day 3 Objectives")]

    [SerializeField] private GameObject w2day3Obj1;
    [SerializeField] private GameObject w2day3Obj2;
    [SerializeField] private GameObject w2day3Obj3;
    [SerializeField] private GameObject w2day3Obj4;

    private bool w2day3Obj1IsDone = false;
    private bool w2day3Obj2IsDone = false;
    private bool w2day3Obj3IsDone = false;
    private bool w2day3Obj4IsDone = false;

    TMP_Text w2day3Obj1text;
    TMP_Text w2day3Obj2text;
    TMP_Text w2day3Obj3text;
    TMP_Text w2day3Obj4text;

    [Header("Week 2, Day 4 Objectives")]

    [SerializeField] private GameObject w2day4Obj1;
    [SerializeField] private GameObject w2day4Obj2;
    [SerializeField] private GameObject w2day4Obj3;

    private bool w2day4Obj1IsDone = false;
    private bool w2day4Obj2IsDone = false;
    private bool w2day4Obj3IsDone = false;

    TMP_Text w2day4Obj1text;
    TMP_Text w2day4Obj2text;
    TMP_Text w2day4Obj3text;

    [Header("Week 2, Day 7 Objectives")]

    [SerializeField] private GameObject w2day7Obj1;
    [SerializeField] private GameObject w2day7Obj2;
    [SerializeField] private GameObject w2day7Obj3;
    [SerializeField] private GameObject w2day7Obj4;

    private bool w2day7Obj1IsDone = false;
    private bool w2day7Obj2IsDone = false;
    private bool w2day7Obj3IsDone = false;
    private bool w2day7Obj4IsDone = false;

    TMP_Text w2day7Obj1text;
    TMP_Text w2day7Obj2text;
    TMP_Text w2day7Obj3text;
    TMP_Text w2day7Obj4text;

    [Header("Week 2, Day 8 Objectives")]

    [SerializeField] private GameObject w2day8Obj1;
    [SerializeField] private GameObject w2day8Obj2;
    [SerializeField] private GameObject w2day8Obj3;
    [SerializeField] private GameObject w2day8Obj4;

    private bool w2day8Obj1IsDone = false;
    private bool w2day8Obj2IsDone = false;
    private bool w2day8Obj3IsDone = false;
    private bool w2day8Obj4IsDone = false;

    TMP_Text w2day8Obj1text;
    TMP_Text w2day8Obj2text;
    TMP_Text w2day8Obj3text;
    TMP_Text w2day8Obj4text;

    [Header("Week 2, Day 10 Objectives")]

    [SerializeField] private GameObject w2day10Obj1;
    [SerializeField] private GameObject w2day10Obj2;

    private bool w2day10Obj1IsDone = false;
    private bool w2day10Obj2IsDone = false;

    TMP_Text w2day10Obj1text;
    TMP_Text w2day10Obj2text;

    [Header("Week 3, Day 1 Objectives")]

    [SerializeField] private GameObject w3day1Obj1;
    [SerializeField] private GameObject w3day1Obj2;
    [SerializeField] private GameObject w3day1Obj3;

    private bool w3day1Obj1IsDone = false;
    private bool w3day1Obj2IsDone = false;
    private bool w3day1Obj3IsDone = false;

    TMP_Text w3day1Obj1text;
    TMP_Text w3day1Obj2text;
    TMP_Text w3day1Obj3text;

    [Header("Week 3, Day 2 Objectives")]

    [SerializeField] private GameObject w3day2Obj1;
    [SerializeField] private GameObject w3day2Obj2;
    [SerializeField] private GameObject w3day2Obj3;

    private bool w3day2Obj1IsDone = false;
    private bool w3day2Obj2IsDone = false;
    private bool w3day2Obj3IsDone = false;

    TMP_Text w3day2Obj1text;
    TMP_Text w3day2Obj2text;
    TMP_Text w3day2Obj3text;

    [Header("Week 3, Day 3 Objectives")]

    [SerializeField] private GameObject w3day3Obj1;
    [SerializeField] private GameObject w3day3Obj2;
    [SerializeField] private GameObject w3day3Obj3;
    [SerializeField] private GameObject w3day3Obj4;

    private bool w3day3Obj1IsDone = false;
    private bool w3day3Obj2IsDone = false;
    private bool w3day3Obj3IsDone = false;
    private bool w3day3Obj4IsDone = false;

    TMP_Text w3day3Obj1text;
    TMP_Text w3day3Obj2text;
    TMP_Text w3day3Obj3text;
    TMP_Text w3day3Obj4text;

    [Header("Week 3, Day 4 Objectives")]

    [SerializeField] private GameObject w3day4Obj1;
    [SerializeField] private GameObject w3day4Obj2;
    [SerializeField] private GameObject w3day4Obj3;

    private bool w3day4Obj1IsDone = false;
    private bool w3day4Obj2IsDone = false;
    private bool w3day4Obj3IsDone = false;

    TMP_Text w3day4Obj1text;
    TMP_Text w3day4Obj2text;
    TMP_Text w3day4Obj3text;

    [Header("Week 3, Day 7 Objectives")]

    [SerializeField] private GameObject w3day7Obj1;
    [SerializeField] private GameObject w3day7Obj2;
    [SerializeField] private GameObject w3day7Obj3;
    [SerializeField] private GameObject w3day7Obj4;

    private bool w3day7Obj1IsDone = false;
    private bool w3day7Obj2IsDone = false;
    private bool w3day7Obj3IsDone = false;
    private bool w3day7Obj4IsDone = false;

    TMP_Text w3day7Obj1text;
    TMP_Text w3day7Obj2text;
    TMP_Text w3day7Obj3text;
    TMP_Text w3day7Obj4text;

    [Header("Week 3, Day 8 Objectives")]

    [SerializeField] private GameObject w3day8Obj1;
    [SerializeField] private GameObject w3day8Obj2;
    [SerializeField] private GameObject w3day8Obj3;
    [SerializeField] private GameObject w3day8Obj4;

    private bool w3day8Obj1IsDone = false;
    private bool w3day8Obj2IsDone = false;
    private bool w3day8Obj3IsDone = false;
    private bool w3day8Obj4IsDone = false;

    TMP_Text w3day8Obj1text;
    TMP_Text w3day8Obj2text;
    TMP_Text w3day8Obj3text;
    TMP_Text w3day8Obj4text;

    [Header("Week 3, Day 10 Objectives")]

    [SerializeField] private GameObject w3day10Obj1;
    [SerializeField] private GameObject w3day10Obj2;

    private bool w3day10Obj1IsDone = false;
    private bool w3day10Obj2IsDone = false;

    TMP_Text w3day10Obj1text;
    TMP_Text w3day10Obj2text;

    [Header("Week 4, Day 1 Objectives")]

    [SerializeField] private GameObject w4day1Obj1;
    [SerializeField] private GameObject w4day1Obj2;
    [SerializeField] private GameObject w4day1Obj3;

    private bool w4day1Obj1IsDone = false;
    private bool w4day1Obj2IsDone = false;
    private bool w4day1Obj3IsDone = false;

    TMP_Text w4day1Obj1text;
    TMP_Text w4day1Obj2text;
    TMP_Text w4day1Obj3text;

    [Header("Week 4, Day 2 Objectives")]

    [SerializeField] private GameObject w4day2Obj1;
    [SerializeField] private GameObject w4day2Obj2;
    [SerializeField] private GameObject w4day2Obj3;

    private bool w4day2Obj1IsDone = false;
    private bool w4day2Obj2IsDone = false;
    private bool w4day2Obj3IsDone = false;

    TMP_Text w4day2Obj1text;
    TMP_Text w4day2Obj2text;
    TMP_Text w4day2Obj3text;

    [Header("Week 4, Day 3 Objectives")]

    [SerializeField] private GameObject w4day3Obj1;
    [SerializeField] private GameObject w4day3Obj2;
    [SerializeField] private GameObject w4day3Obj3;
    [SerializeField] private GameObject w4day3Obj4;

    private bool w4day3Obj1IsDone = false;
    private bool w4day3Obj2IsDone = false;
    private bool w4day3Obj3IsDone = false;
    private bool w4day3Obj4IsDone = false;

    TMP_Text w4day3Obj1text;
    TMP_Text w4day3Obj2text;
    TMP_Text w4day3Obj3text;
    TMP_Text w4day3Obj4text;

    [Header("Week 4, Day 4 Objectives")]

    [SerializeField] private GameObject w4day4Obj1;
    [SerializeField] private GameObject w4day4Obj2;
    [SerializeField] private GameObject w4day4Obj3;

    private bool w4day4Obj1IsDone = false;
    private bool w4day4Obj2IsDone = false;
    private bool w4day4Obj3IsDone = false;

    TMP_Text w4day4Obj1text;
    TMP_Text w4day4Obj2text;
    TMP_Text w4day4Obj3text;

    [Header("Week 4, Day 7 Objectives")]

    [SerializeField] private GameObject w4day7Obj1;
    [SerializeField] private GameObject w4day7Obj2;
    [SerializeField] private GameObject w4day7Obj3;
    [SerializeField] private GameObject w4day7Obj4;

    private bool vday7Obj1IsDone = false;
    private bool w4day7Obj2IsDone = false;
    private bool vday7Obj3IsDone = false;
    private bool w4day7Obj4IsDone = false;

    TMP_Text w4day7Obj1text;
    TMP_Text w4day7Obj2text;
    TMP_Text w4day7Obj3text;
    TMP_Text w4day7Obj4text;

    [Header("Week 4, Day 8 Objectives")]

    [SerializeField] private GameObject w4day8Obj1;
    [SerializeField] private GameObject w4day8Obj2;
    [SerializeField] private GameObject w4day8Obj3;
    [SerializeField] private GameObject w4day8Obj4;

    private bool w4day8Obj1IsDone = false;
    private bool w4day8Obj2IsDone = false;
    private bool w4day8Obj3IsDone = false;
    private bool w4day8Obj4IsDone = false;

    TMP_Text w4day8Obj1text;
    TMP_Text w4day8Obj2text;
    TMP_Text w4day8Obj3text;
    TMP_Text w4day8Obj4text;

    [Header("Week 4, Day 10 Objectives")]

    [SerializeField] private GameObject w4day10Obj1;
    [SerializeField] private GameObject w4day10Obj2;

    private bool w4day10Obj1IsDone = false;
    private bool w4day10Obj2IsDone = false;

    TMP_Text w4day10Obj1text;
    TMP_Text w4day10Obj2text;

    [Header("Week 5, Day 1 Objectives")]

    [SerializeField] private GameObject w5day1Obj1;
    [SerializeField] private GameObject w5day1Obj2;
    [SerializeField] private GameObject w5day1Obj3;

    private bool w5day1Obj1IsDone = false;
    private bool w5day1Obj2IsDone = false;
    private bool w5day1Obj3IsDone = false;

    TMP_Text w5day1Obj1text;
    TMP_Text w5day1Obj2text;
    TMP_Text w5day1Obj3text;

    [Header("Week 5, Day 2 Objectives")]

    [SerializeField] private GameObject w5day2Obj1;
    [SerializeField] private GameObject w5day2Obj2;
    [SerializeField] private GameObject w5day2Obj3;

    private bool w5day2Obj1IsDone = false;
    private bool w5day2Obj2IsDone = false;
    private bool w5day2Obj3IsDone = false;

    TMP_Text w5day2Obj1text;
    TMP_Text w5day2Obj2text;
    TMP_Text w5day2Obj3text;

    [Header("Week 5, Day 3 Objectives")]

    [SerializeField] private GameObject w5day3Obj1;
    [SerializeField] private GameObject w5day3Obj2;
    [SerializeField] private GameObject w5day3Obj3;
    [SerializeField] private GameObject w5day3Obj4;

    private bool w5day3Obj1IsDone = false;
    private bool w5day3Obj2IsDone = false;
    private bool w5day3Obj3IsDone = false;
    private bool w5day3Obj4IsDone = false;

    TMP_Text w5day3Obj1text;
    TMP_Text w5day3Obj2text;
    TMP_Text w5day3Obj3text;
    TMP_Text w5day3Obj4text;

    [Header("Week 5, Day 4 Objectives")]

    [SerializeField] private GameObject w5day4Obj1;
    [SerializeField] private GameObject w5day4Obj2;
    [SerializeField] private GameObject w5day4Obj3;

    private bool w5day4Obj1IsDone = false;
    private bool w5day4Obj2IsDone = false;
    private bool w5day4Obj3IsDone = false;

    TMP_Text w5day4Obj1text;
    TMP_Text w5day4Obj2text;
    TMP_Text w5day4Obj3text;

    [Header("Week 5, Day 7 Objectives")]

    [SerializeField] private GameObject w5day7Obj1;
    [SerializeField] private GameObject w5day7Obj2;
    [SerializeField] private GameObject w5day7Obj3;
    [SerializeField] private GameObject w5day7Obj4;

    private bool w5day7Obj1IsDone = false;
    private bool w5day7Obj2IsDone = false;
    private bool w5day7Obj3IsDone = false;
    private bool w5day7Obj4IsDone = false;

    TMP_Text w5day7Obj1text;
    TMP_Text w5day7Obj2text;
    TMP_Text w5day7Obj3text;
    TMP_Text w5day7Obj4text;

    [Header("Week 5, Day 10 Objectives")]

    [SerializeField] private GameObject w5day10Obj1;
    [SerializeField] private GameObject w5day10Obj2;

    private bool w5day10Obj1IsDone = false;
    private bool w5day10Obj2IsDone = false;

    TMP_Text w5day10Obj1text;
    TMP_Text w5day10Obj2text;

    [Header("Day by Day Headings")]

    [SerializeField] private GameObject day1All;
    [SerializeField] private GameObject day2All;
    [SerializeField] private GameObject day3All;
    [SerializeField] private GameObject day4All;
    [SerializeField] private GameObject day7All;
    [SerializeField] private GameObject day8All;
    [SerializeField] private GameObject day10All;

    [SerializeField] private GameObject day14All;
    [SerializeField] private GameObject day15All;
    [SerializeField] private GameObject day16All;
    [SerializeField] private GameObject day20All;
    [SerializeField] private GameObject day21All;
    [SerializeField] private GameObject day24All;

    [SerializeField] private GameObject day30All;
    [SerializeField] private GameObject day31All;
    [SerializeField] private GameObject day32All;
    [SerializeField] private GameObject day35All;
    [SerializeField] private GameObject day36All;
    [SerializeField] private GameObject day39All;

    [SerializeField] private GameObject day42All;
    [SerializeField] private GameObject day43All;
    [SerializeField] private GameObject day44All;
    [SerializeField] private GameObject day47All;
    [SerializeField] private GameObject day48All;
    [SerializeField] private GameObject day50All;

    [SerializeField] private GameObject day55All;
    [SerializeField] private GameObject day56All;
    [SerializeField] private GameObject day57All;
    [SerializeField] private GameObject day60All;

    [Header("script references")]
    [SerializeField] private DayCounter dayCounter;
    [SerializeField] private startdaycount startDayCount;

    [Header("Log off Button")]
    [SerializeField] private GameObject logOffButton;
    [SerializeField] private GameObject logOffReminder;

    [Header("day Specific Objects")]
    [SerializeField] private GameObject Friend1;
    [SerializeField] private GameObject Friend2;
    [SerializeField] private GameObject Friend3;
    [SerializeField] private GameObject Friend4;
    [SerializeField] private GameObject Friend5;

    [SerializeField] private GameObject Sheep1;
    [SerializeField] private GameObject Sheep2;
    [SerializeField] private GameObject Sheep3;
    [SerializeField] private GameObject Sheep4;
    [SerializeField] private GameObject Sheep5;

    [SerializeField] private GameObject sheep1Trapped;
    [SerializeField] private GameObject sheep2Trapped;
    [SerializeField] private GameObject sheep3Trapped;
    [SerializeField] private GameObject sheep4Trapped;
    [SerializeField] private GameObject sheep5Trapped;

    [SerializeField] private GameObject Customer1;
    [SerializeField] private GameObject Customer2;
    [SerializeField] private GameObject Customer3;
    [SerializeField] private GameObject Customer4;

    [SerializeField] private GameObject Profile1;
    [SerializeField] private GameObject Profile2;
    [SerializeField] private GameObject Profile3;
    [SerializeField] private GameObject Profile4;
    [SerializeField] private GameObject Profile5;

    [SerializeField] private GameObject TaxesButton;
    [SerializeField] private GameObject noTaxes;

    [SerializeField] private GameObject policeAlert1;
    [SerializeField] private GameObject policeAlert2;
    [SerializeField] private GameObject policeAlert3;
    [SerializeField] private GameObject policeAlert4;

    [SerializeField] private GameObject policeNotification;
    [SerializeField] private GameObject messageNotification;
    [SerializeField] private GameObject socialMediaNotification;
    [SerializeField] private GameObject taxesNotification;

    [SerializeField] private GameObject noFriendsAlert;
    [SerializeField] private GameObject noFriendsSuggestedAlert;

    [SerializeField] private GameObject Frontdoor;
    [SerializeField] private GameObject livestockRoomDoor;

    [Header("dialogue")]
    [SerializeField] private GameObject day3SheepDialogue;

    private float transTime = 5f;

    [Header("Day checkers")]
    [SerializeField] private bool day1IsComplete;
    [SerializeField] private bool day2IsComplete;
    [SerializeField] private bool day3IsComplete;
    [SerializeField] private bool day7IsComplete;
    [SerializeField] private bool day8IsComplete;
    [SerializeField] private bool day10IsComplete;

    // week 4 - medium week

    [SerializeField] private bool day14IsComplete;
    [SerializeField] private bool day15IsComplete;
    [SerializeField] private bool day16IsComplete;
    [SerializeField] private bool day20IsComplete;
    [SerializeField] private bool day21IsComplete;
    [SerializeField] private bool day24IsComplete;

    // week 3 - hard week

    [SerializeField] private bool day30IsComplete;
    [SerializeField] private bool day31IsComplete;
    [SerializeField] private bool day32IsComplete;
    [SerializeField] private bool day35IsComplete;
    [SerializeField] private bool day36IsComplete;
    [SerializeField] private bool day39IsComplete;
    
    // week 4 - hardest week

    [SerializeField] private bool day42IsComplete;
    [SerializeField] private bool day43IsComplete;
    [SerializeField] private bool day44IsComplete;
    [SerializeField] private bool day47IsComplete;
    [SerializeField] private bool day48IsComplete;
    [SerializeField] private bool day50IsComplete;

    // week 5 - arrest week

    [SerializeField] private bool day55IsComplete;
    [SerializeField] private bool day56IsComplete;
    [SerializeField] private bool day57IsComplete;
    [SerializeField] private bool day60IsComplete;

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

        noFriendsSuggestedAlert.gameObject.SetActive(true);
        noFriendsAlert.gameObject.SetActive(true);

        day1IsComplete = false;
        day2IsComplete = false;
        day3IsComplete = false;
        day7IsComplete = false;
       
        Frontdoor.gameObject.SetActive(true);
        livestockRoomDoor.gameObject.SetActive(true);
        
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
        }

        if (dayCounter.dayCount == 3)
        {
            day2All.gameObject.SetActive(false);
            day3All.gameObject.SetActive(true);

        }

        if (dayCounter.dayCount == 4)
        {
            day3All.gameObject.SetActive(false);

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
            if (day4Obj1IsDone == true)
            {
                Sheep1.gameObject.SetActive(true);
            }
        }

        if (dayCounter.dayCount == 7)
        {
            if (day7Obj1IsDone == true)
            {
                if (day7Obj2IsDone == true)
                {
                    livestockRoomDoor.gameObject.SetActive(false);
                }
            }
        }

        if (dayCounter.dayCount == 7)
        {
            if (day7Obj1IsDone == true)
            {
                if (day7Obj2IsDone == true)
                {
                    if (day7Obj3IsDone == true)
                    {
                        if (day7Obj4IsDone == true)
                        {
                            logOffButton.gameObject.GetComponent<Button>().interactable = true;
                            logOffReminder.gameObject.SetActive(true);
                        }
                    }
                }
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
            day1IsComplete = true;
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
            day2IsComplete = true;
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
            day3IsComplete = true;
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
        day4Obj3text = day4Obj3.gameObject.GetComponent<TMP_Text>();
        day4Obj3text.color = Color.green;
        day4Obj3IsDone = true;
    }

    public void d7o1complete()
    {
        if (dayCounter.dayCount == 7)
        {
            day7Obj1text = day7Obj1.gameObject.GetComponent<TMP_Text>();
            day7Obj1text.color = Color.green;
            day7Obj1IsDone = true;
        }
    }

    public void d7o2complete()
    {
        if (dayCounter.dayCount == 7)
        {
            day7Obj2text = day7Obj2.gameObject.GetComponent<TMP_Text>();
            day7Obj2text.color = Color.green;
            day7Obj2IsDone = true;
        }

    }

    public void d7o3complete()
    {
        if (dayCounter.dayCount == 7)
        {
            day7Obj3text = day7Obj3.gameObject.GetComponent<TMP_Text>();
            day7Obj3text.color = Color.green;
            day7Obj3IsDone = true;
        }
    }

    public void d7o4complete()
    {
        if (dayCounter.dayCount == 7)
        {
            day7Obj4text = day7Obj4.gameObject.GetComponent<TMP_Text>();
            day7Obj4text.color = Color.green;
            day7Obj4IsDone = true;
        }
    }

    

    public void day1Complete()
    {
        if (dayCounter.dayCount == 1 && day1IsComplete == true)
        {
            logOffButton.gameObject.GetComponent<Button>().interactable = false;
            logOffReminder.gameObject.SetActive(false);
            dayCounter.ChangeDay();
            startDayCount.ShowDate();
            day2alert();
            DonorAppear1();
            // turn off pinging SFX
        }
    }

    public void day2Complete()
    {
        if (dayCounter.dayCount == 2 && day2IsComplete == true)
        {
            logOffButton.gameObject.GetComponent<Button>().interactable = false;
            logOffReminder.gameObject.SetActive(false);
            dayCounter.ChangeDay();
            startDayCount.ShowDate();
            day3alert();
            FriendAppear1();
            // turn off pinging SFX
        }
    }

    public void day3Complete()
    {
        if (dayCounter.dayCount == 3 && day3IsComplete == true)
        {
            logOffButton.gameObject.GetComponent<Button>().interactable = false;
            logOffReminder.gameObject.SetActive(false);
            dayCounter.ChangeDay();
            startDayCount.ShowDate();
            day4Taxes();
            day4All.gameObject.SetActive(true);
            // turn off pinging SFX
        }

    }

    public void day4Complete()
    {
        if (dayCounter.dayCount == 4)
        {
            // sheep wail SFX goes here
            day3SheepDialogue.gameObject.SetActive(false);
            Frontdoor.gameObject.SetActive(true);
            dayCounter.dayCount = 7;
            startDayCount.ShowDate();
            PoliceAlert1();
            sheep1Trapped.gameObject.SetActive(true);
        }
    }

    public void day7Complete()
    {
        if (dayCounter.dayCount == 7)
        {
            logOffButton.gameObject.GetComponent<Button>().interactable = false;
            dayCounter.ChangeDay();
            startDayCount.ShowDate();
        }
    }

    public void day2alert()
    {
        socialMediaNotification.gameObject.SetActive(true);
    }

    public void day3alert()
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

    public void DonorAppear1()
    {
        noFriendsSuggestedAlert.gameObject.SetActive(true);
        Profile1.gameObject.SetActive(true);
    }

    public void FriendAppear1()
    {
        Friend1.gameObject.SetActive(true);
        noFriendsAlert.gameObject.SetActive(false);
    }

    public void transition()
    {
        StartCoroutine(Day7transition());
    }

    IEnumerator Day7transition()
    {
        gameObject.GetComponent<sheepDay7>().enabled = true;
        yield return new WaitForSeconds(transTime);
        gameObject.GetComponent<sheepDay7>().enabled = false;
    }
}
