using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class FrontDoor : MonoBehaviour
{
    public bool canOpen = false;
    [SerializeField] private DayCounter dayCounter;
    [SerializeField] private ObjectiveCounter objectiveCounter;

    [SerializeField] private GameObject LockedAlert;
    private float waitfordoorLock = 3f;

    private void Start()
    {
        canOpen = false;
        LockedAlert.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (canOpen == false)
        {
            gameObject.SetActive(true);
            Debug.Log("Door is Locked!!!");
        }
    }
    public void OpenDoor()
    {
        // week 1

        if (dayCounter.dayCount == 4)
        {
            canOpen = true;
            
            if (objectiveCounter.day4Obj1IsDone == true)
            {
                gameObject.SetActive(false);
                objectiveCounter.d4o2complete();
            }

        }

        if (dayCounter.dayCount == 8)
        {
            canOpen = true;

            if (objectiveCounter.day8Obj1IsDone == true)
            {
                gameObject.SetActive(false);
                objectiveCounter.d8o2complete();
            }

        }


        if (dayCounter.dayCount == 10)
        {
            canOpen = true;

            objectiveCounter.d10o1complete();
            gameObject.SetActive(false);
        }

        // week 2

        if (dayCounter.dayCount == 17)
        {
            canOpen = true;

            if (objectiveCounter.w2day4Obj1IsDone == true)
            {
                gameObject.SetActive(false);
                // week 2 day 4 objective 2 complete
            }
        }

        if (dayCounter.dayCount == 21)
        {
            canOpen = true;

            if (objectiveCounter.w2day8Obj1IsDone == true)
            {
                gameObject.SetActive(false);
                // week 2 day 8 objective 3 compelete
            }
        }

        if (canOpen == false)
        {
            StartCoroutine(DoorisLOcked());
        }
    }

    IEnumerator DoorisLOcked()
    {
        LockedAlert.gameObject.SetActive(true);
        yield return new WaitForSeconds(waitfordoorLock);
        LockedAlert.gameObject.SetActive(false);
    }


}
