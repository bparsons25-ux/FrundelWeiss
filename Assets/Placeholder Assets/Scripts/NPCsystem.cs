using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NPCsystem : MonoBehaviour
{

    // this script serves as the NPC spawning and management script 

    [Header("Object References")]

    public GameObject fatCustomer;
    public GameObject skinnyCustomer;
    public GameObject fatCustomer2;
    public GameObject policeOfficer;
    public GameObject skinnyCustomer2;
    public GameObject policeOfficer2;

    public bool fatCustomerIsActive;
    public bool fatCustomer2IsActive;
    public bool skinnyCustomerIsActive;
    public bool policeOfficer1IsActive;
    public bool skinnyCustomer2IsActive;
    public bool policeOfficer2IsActive;

    private bool demoIsFinished;
    public bool saleIsDone;

    [Header("Selling Objects")]

    public GameObject sellingArea;
    [SerializeField] private MoneyManager moneyManager;

    [Header("Sale Checks")]
    public bool customer1Sold;
    public bool customer2Sold;
    public bool customer3Sold;
    public bool policeBribed;
    public bool customer4Sold;
    public bool police2Bribed;


    [Header("Spawn Countdown")]

    public float timeuntilSpawn1 = 60f;
    public int spawnCount = 0;

    [Header("Demo End Screen")]

    public GameObject demoEndCanvas;

    public static bool hasSold;
    
    private void Start()
    {
        fatCustomerIsActive = false;
        fatCustomer2IsActive = false;
        skinnyCustomerIsActive = false; 
        skinnyCustomer2IsActive = false;
        policeOfficer1IsActive = false;
        policeOfficer2IsActive = false;
        spawnCount += 1;

        timeuntilSpawn1 = 1f;

        demoEndCanvas.gameObject.SetActive(false);

        

    }

    private void Update()
    {
        // Countdown until first NPC spawns

        if (timeuntilSpawn1 > 0)
        {
            timeuntilSpawn1 -= Time.deltaTime;
            Debug.Log(timeuntilSpawn1);
        }

        else if (timeuntilSpawn1 < 0)
        {
            timeuntilSpawn1 = 0;
            fatCustomerIsActive = true;
        }

        // when Demo finishes (Player has cleared all NPCs and all Police.)
        // demoIsFinished Becomes true when the player stops 

        if (demoIsFinished == true)
        {
            demoEndCanvas.gameObject.SetActive(true);
        }

        // when are sale is complete then we increase the sale count.

        if (saleIsDone == true)
        {
            spawnCount++;
            saleIsDone = false;
        }


        if (fatCustomerIsActive == true)
        {
            fatCustomer.GetComponent<NPCmovement>().enabled = true;
        }
        else
        {
            fatCustomer.GetComponent<NPCmovement>().enabled = false;
        }


        if (fatCustomer2IsActive == true)
        {
            fatCustomer2.GetComponent<NPCmovement>().enabled = true;
        }
        else
        {
            fatCustomer2.GetComponent<NPCmovement>().enabled = false;
        }



        if (skinnyCustomerIsActive == true)
        {
            skinnyCustomer.GetComponent<NPCmovement>().enabled = true;
        }
        else
        {
            skinnyCustomer2.GetComponent<NPCmovement>().enabled = false;
        }


        if (skinnyCustomer2IsActive == true)
        {
            skinnyCustomer2.GetComponent<NPCmovement>().enabled = true;
        }
        else
        {
            skinnyCustomer2.GetComponent<NPCmovement>().enabled = false;
        }


        if (policeOfficer1IsActive == true)
        {
            policeOfficer.GetComponent<NPCmovement>().enabled = true;
        }
        else
        {
            policeOfficer.GetComponent<NPCmovement>().enabled = false;
        }


        if (policeOfficer2IsActive == true)
        {
            policeOfficer2.GetComponent<NPCmovement>().enabled = true;
        }
        else
        {
            policeOfficer2.GetComponent<NPCmovement>().enabled = false;
        }

        // checks if sale is done and then adds onto the index

        if (saleIsDone == true)
        {
            spawnCount++;
            saleIsDone = false;
        }

        if (spawnCount == 2)
        {
            skinnyCustomerIsActive = true;
            fatCustomerIsActive = false;
        }

        if (spawnCount == 3)
        {
            fatCustomer2IsActive = true;
            skinnyCustomerIsActive = false;
        }

        if (spawnCount == 4)
        {
            policeOfficer1IsActive = true;
            fatCustomer2IsActive = false;
        }

        if (spawnCount == 5)
        {
           skinnyCustomer2IsActive = true;
           policeOfficer1IsActive = false;
        }


        if (spawnCount == 6)
        {
            policeOfficer2IsActive = true;
            skinnyCustomer2IsActive = false;
        }


        if (spawnCount == 7)
        {
            demoEndCanvas.gameObject.SetActive(true);
            policeOfficer2IsActive = true;
        }




    }




    public void SoldHeart()
    {
        moneyManager.money += 500;
        moneyManager.moneyText.text = "$" + moneyManager.money.ToString();
        PlayerPrefs.SetInt("money", moneyManager.money);
        Debug.Log("Sold Heart");
    }

    public void SoldLiver()
    {
        moneyManager.money += 300;
        moneyManager.moneyText.text = "$" + moneyManager.money.ToString();
        PlayerPrefs.SetInt("money", moneyManager.money);
        Debug.Log("Sold Liver");
    }

    public void SoldLeftKidney()
    {
        moneyManager.money += 100;
        moneyManager.moneyText.text = "$" + moneyManager.money.ToString();
        PlayerPrefs.SetInt("money", moneyManager.money);
        Debug.Log("Sold Left Kidney");
    }

    public void SoldRightKidney()
    {
        moneyManager.money += 100;
        moneyManager.moneyText.text = "$" + moneyManager.money.ToString();
        PlayerPrefs.SetInt("money", moneyManager.money);
        Debug.Log("Sold Right Kidney");
    }

}