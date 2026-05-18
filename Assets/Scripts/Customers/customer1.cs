using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class customer1 : MonoBehaviour
{
    [SerializeField] private ObjectiveCounter counter;
    [SerializeField] private GeneralFunctions generalFunctions;
    [SerializeField] private DayCounter dayCounter;

    [SerializeField] private WaypointMovement waypointMovement;
    [SerializeField] private PickUpRaycastScript pickUpRaycastScript;

    [SerializeField] private CustomerOrderCountdown orderCountdown;
    [SerializeField] private GameObject customerCountDown;

    [SerializeField] private MoneyManager moneyManager;

    [SerializeField] private WaypointMovement waypointMovement1;
    [SerializeField] private GoHomeWaypointMovement waypointMovement2;

    [SerializeField] private float completeFail = 5f;

    public GameObject orderFailALert;
    public GameObject customerSuccess;

    public GameObject FrontDoorobject;
    [SerializeField] private FrontDoor frontDoorObject;

    private bool orderisStarted;
    private bool orderisCompleted;

    public GameObject orderUI;
    public GameObject orderUIparent;
    public GameObject ClientChat;

    [SerializeField] private GeneralFunctions func;

    private bool leftKidneyDelivered;
    private bool rightKidneyDelivered;

    private int failedchances = 2;

    private void Start()
    {
        customerCountDown.gameObject.SetActive(false);
        orderisStarted = false;

        waypointMovement1.enabled = false;
        waypointMovement2.enabled = false;

        leftKidneyDelivered = false;
        rightKidneyDelivered = false;

    }

    private void Update()
    {
        if (orderCountdown.remainingTime < 0 && orderisStarted == true)
        {
            counter.d8o4incomplete();
            PickUpRaycastScript.canPickUp = true;
            customerCountDown.gameObject.SetActive(false);
            orderisStarted = false;
            OrderFailed();
        }

        if (waypointMovement1.index == 2)
        {
            FrontDoorobject.gameObject.SetActive(false);         // Before Sale - Opens Front Door.
        }

        if (waypointMovement1.index == 3)
        {
            FrontDoorobject.gameObject.SetActive(true);
            frontDoorObject.canOpen = false;
            // door close SFX
        }

        if (waypointMovement2.index == 3)
        {
            frontDoorObject.canOpen = true;
            FrontDoorobject.gameObject.SetActive(false);
        }

        if (waypointMovement2.index == 4)
        {
            FrontDoorobject.gameObject.SetActive(true);
            frontDoorObject.canOpen = false;
            // door close SFX
        }

        if (orderisCompleted == true)
        {
            waypointMovement1.enabled = false;
            waypointMovement2.enabled = true;

            if (waypointMovement2.index == 4)
            {
                Destroy(gameObject);
            }
        }

        if (waypointMovement1.index == 4)
        {
            waypointMovement1.enabled = false;
        }

        if (dayCounter.dayCount == 21)
        {
            if (failedchances == 0)
            {
                orderisStarted = false;
                orderisCompleted = true;
                MoveBack();
                SuccessAlert();
            }
        }



        if (waypointMovement1.index > 0)
        {
            ClientChat.gameObject.SetActive(false);
        }

        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (dayCounter.dayCount == 8)
        {
            if (collision.CompareTag("Heart Jar") && orderCountdown.remainingTime > 0 && orderisStarted == true)
            {

                if (dayCounter.dayCount == 8)
                {
                    counter.d8o4complete();
                }

                Destroy(collision.gameObject);
                PickUpRaycastScript.canPickUp = true;
                customerCountDown.gameObject.SetActive(false);
                moneyManager.Heartsale();
                orderisStarted = false;
                orderisCompleted = true;
                MoveBack();
                SuccessAlert();
                // Play Cashier Ching Sound Effect?
            }

            if (collision.CompareTag("Left Kidney Jar") && orderCountdown.remainingTime > 0 && orderisStarted == true)
            {
                counter.d8o4incomplete();
                Destroy(collision.gameObject);
                PickUpRaycastScript.canPickUp = true;
                customerCountDown.gameObject.SetActive(false);
                moneyManager.Heartsale();
                orderisStarted = false;
                orderisCompleted = true;
                MoveBack();
                StartCoroutine(FailAlert());
            }

            if (collision.CompareTag("Right Kidney Jar") && orderCountdown.remainingTime > 0 && orderisStarted == true)
            {
                counter.d8o4incomplete();
                Destroy(collision.gameObject);
                PickUpRaycastScript.canPickUp = true;
                customerCountDown.gameObject.SetActive(false);
                moneyManager.Heartsale();
                orderisStarted = false;
                orderisCompleted = true;
                MoveBack();
                StartCoroutine(FailAlert());
            }

            if (collision.CompareTag("Liver Jar") && orderCountdown.remainingTime > 0 && orderisStarted == true)
            {
                counter.d8o4incomplete();
                Destroy(collision.gameObject);
                PickUpRaycastScript.canPickUp = true;
                customerCountDown.gameObject.SetActive(false);
                moneyManager.Heartsale();
                orderisStarted = false;
                orderisCompleted = true;
                MoveBack();
                StartCoroutine(FailAlert());
            }

            if (collision.CompareTag("Destroy Zone") && orderisCompleted ==  true)
            {
                Destroy(gameObject);
                Debug.Log("Customer Destroyed");
            }

            

        }

        if (dayCounter.dayCount == 21)
        {
            if (orderisCompleted == true)
            {
                if (collision.CompareTag("Liver Jar") && orderCountdown.remainingTime > 0 && orderisStarted == true)
                {
                    Destroy(collision.gameObject);
                    PickUpRaycastScript.canPickUp = true;
                    // play wrong SFX
                }

                if (collision.CompareTag("Right Kidney Jar") && orderCountdown.remainingTime > 0 && orderisStarted == true)
                {
                    Destroy(collision.gameObject);
                    PickUpRaycastScript.canPickUp = true;
                    leftKidneyDelivered = true;
                    // Colour icon Green here
                    // Play ping SFX
                }

                if (collision.CompareTag("Left Kidney Jar") && orderCountdown.remainingTime > 0 && orderisStarted == true)
                {
                    Destroy(collision.gameObject);
                    PickUpRaycastScript.canPickUp = true;
                    rightKidneyDelivered = true;
                    // Colour icon Green here
                    // Play ping SFX
                }

                if (collision.CompareTag("Heart Jar") && orderCountdown.remainingTime > 0 && orderisStarted == true)
                {
                    Destroy(collision.gameObject);
                    PickUpRaycastScript.canPickUp = true;
                }

            }
        }

    }

    public void StartOrder()
    {
        orderCountdown.remainingTime = 120f;
        customerCountDown.gameObject.SetActive(true);
        orderisStarted = true;
    }

    public void OrderFailed()
    {
        waypointMovement1.enabled = false;
        waypointMovement2.enabled = true;
    }

    public void startToMove()
    {
        waypointMovement1.enabled = true;
    }

    public void MoveBack()
    {
        waypointMovement1.enabled = false;
        waypointMovement2.enabled = true;
        transform.Rotate(Vector3.up, 180);

    }

    public void orderConfirmation()
    {
        if (waypointMovement1.index == 4 && orderisStarted == false)
        {
            func.MouseUnlock();
            func.CamLock();
            func.PlayerFreeze();
            orderUIparent.gameObject.SetActive(true);
            orderUI.gameObject.SetActive(true);
        }

        else
        {
            return;
        }
    }

    public void DialogueStart()
    {
        if (orderisStarted == false && waypointMovement1.index == 0)
        {
            func.MouseUnlock();
            func.CamLock();
            func.PlayerFreeze();
            ClientChat.gameObject.SetActive(true);
        }

        else if (waypointMovement1.index > 0)
        {
            return;
        }
    }

    IEnumerator FailAlert()
    {
        orderFailALert.gameObject.SetActive(true);
        yield return new WaitForSeconds(completeFail);
        orderFailALert.gameObject.SetActive(false);
    }

    IEnumerator SuccessAlert()
    {
        customerSuccess.gameObject.SetActive(true);
        yield return new WaitForSeconds(completeFail);
        customerSuccess.gameObject.SetActive(false);
    }







}







