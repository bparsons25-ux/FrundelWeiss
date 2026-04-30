using System.Runtime.CompilerServices;
using UnityEngine;

public class NPCsystem : MonoBehaviour
{
    [Header("Object References")]

    public GameObject fatCustomer;
    public GameObject skinnyCustomer;
    public GameObject fatCustomer2;
    public GameObject policeOfficer;

    private bool fatCustomerIsActive;
    private bool fatCustomer2IsActive;
    private bool skinnyCustomerIsActive;
    private bool policeOfficerIsActive;

    [Header("Selling Objects")]

    public GameObject sellingArea;
    [SerializeField] private MoneyManager moneyManager;

    [Header("Spawn Countdown")]

    public float timeuntilSpawn1;
    
    private void Start()
    {
        fatCustomerIsActive = false;
        fatCustomer2IsActive = false;
        skinnyCustomerIsActive = false; 
        policeOfficerIsActive = false;

        

    }

    private void Update()
    {
        if (timeuntilSpawn1 > 0)
        {
            timeuntilSpawn1 -= Time.deltaTime;
        }

        else if (timeuntilSpawn1 < 0)
        {
            timeuntilSpawn1 = 0;
            fatCustomerIsActive = true;
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
