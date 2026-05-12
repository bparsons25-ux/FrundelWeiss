using System;
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
    [SerializeField] private WaypointMovement waypointMovement2;

    public GameObject FrontDoorobject;
    [SerializeField] private FrontDoor frontDoorObject;

    private bool orderisStarted;

    public GameObject orderUI;
    public GameObject ClientChat;

    [SerializeField] private GeneralFunctions func;

    private void Start()
    {
        customerCountDown.gameObject.SetActive(false);
        orderisStarted = false;

        waypointMovement1.enabled = false;
        waypointMovement2.enabled = false;

        
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

        if (waypointMovement2.index == 2)
        {
            frontDoorObject.canOpen = true;
            FrontDoorobject.gameObject.SetActive(false);
        }

        if (waypointMovement2.index == 3)
        {
            FrontDoorobject.gameObject.SetActive(true);
            frontDoorObject.canOpen = false;
            // door close SFX
        }

        if (waypointMovement2.index > 4)
        {
            Destroy(gameObject);

        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (dayCounter.dayCount == 8)
        {
            if (collision.CompareTag("Heart Jar") && orderCountdown.remainingTime > 0 && orderisStarted == true)
            {
                counter.d8o4complete();
                Destroy(collision.gameObject);
                PickUpRaycastScript.canPickUp = true;
                customerCountDown.gameObject.SetActive(false);
                moneyManager.Heartsale();
                orderisStarted = false;
                MoveBack();
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
                MoveBack();
            }

            if (collision.CompareTag("Right Kidney Jar") && orderCountdown.remainingTime > 0 && orderisStarted == true)
            {
                counter.d8o4incomplete();
                Destroy(collision.gameObject);
                PickUpRaycastScript.canPickUp = true;
                customerCountDown.gameObject.SetActive(false);
                moneyManager.Heartsale();
                orderisStarted = false;
                MoveBack();
            }

            if (collision.CompareTag("Liver Jar") && orderCountdown.remainingTime > 0 && orderisStarted == true)
            {
                counter.d8o4incomplete();
                Destroy(collision.gameObject);
                PickUpRaycastScript.canPickUp = true;
                customerCountDown.gameObject.SetActive(false);
                moneyManager.Heartsale();
                orderisStarted = false;
                MoveBack();
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

    }

    public void orderConfirmation()
    {
        if (waypointMovement1.index == 5 && orderisStarted == false)
        {
            func.MouseUnlock();
            func.CamLock();
            func.PlayerFreeze();
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







}







