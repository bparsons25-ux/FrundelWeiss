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

    private bool fatCustomerIsActive;
    private bool fatCustomer2IsActive;
    private bool skinnyCustomerIsActive;
    private bool policeOfficer1IsActive;
    private bool skinnyCustomer2IsActive;
    private bool policeOfficer2IsActive;

    private bool demoIsFinished;
    public bool saleIsDone;

    [Header("Selling Objects")]

    public GameObject sellingArea;
    [SerializeField] private MoneyManager moneyManager;

    [Header("Spawn Countdown")]

    public float timeuntilSpawn1;
    public int spawnCount = 0;

    [Header("Demo End Screen")]

    public GameObject demoEndCanvas;

    public static bool hasSold;
    
    private void Start()
    {
        fatCustomerIsActive = false;
        fatCustomer2IsActive = false;
        skinnyCustomerIsActive = false; 
        policeOfficer1IsActive = false;
        spawnCount += 1;

        demoEndCanvas.gameObject.SetActive(false);

        

    }

    private void Update()
    {
        // Countdown until first NPC spawns

        if (timeuntilSpawn1 > 0)
        {
            timeuntilSpawn1 -= Time.deltaTime;
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
