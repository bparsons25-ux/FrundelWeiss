using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using System.Numerics;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{

    public static MoneyManager instance;
    public TextMeshProUGUI moneyText;

    [Header ("Script References")]

    [SerializeField] Countdown countdown;
    

    [Header("Taxes")]

    public GameObject taxIndicator;
    public GameObject taxesbutton;
    public bool taxesPaid;
    public float taxCooldown;

    public bool notInDebt;


    public int money;

    private void Awake()
    {
        
        instance = this;
    }

    void Start()
    {
        
        money = PlayerPrefs.GetInt("money", 500);
        moneyText.text = "$" + money.ToString();


        taxCooldown = 180f;
    }

    void Update()
    {
        if (taxCooldown > 0)
        {
            taxCooldown -= Time.deltaTime;
            taxesPaid = true;
            taxesButtonNotInteract();
        }

        else if (taxCooldown < 0)
        {
            countdown.gameObject.SetActive(true);
            taxIndicator.gameObject.SetActive(true);
            taxesButtonInteract();
            taxesPaid = false;
        }

        if (money < 0)
        {
           
            countdown.gameObject.SetActive(true);
            moneyText.color = Color.red;
        }

        else if (money > 0)
        {
            countdown.remainingTime = 180f;
            moneyText.color = Color.white;
            notInDebt = true;
        }

        if (taxesPaid = true && notInDebt == true)
        {
            
            countdown.gameObject.SetActive(false);
        }

        if (taxesPaid == true)
        {

            taxIndicator.gameObject.SetActive(false);
        }

        
    }

    

    public void AddMoneySmall()
    {
        money += 50;
        moneyText.text = "$" + money.ToString();
        PlayerPrefs.SetInt("money", money);
    }

    public void AddMoneyLarge()
    {
        money += 100;
        moneyText.text = "$" + money.ToString();
        PlayerPrefs.SetInt("money", money);
    }


    public void LoseMoneySmall()
    {
        money -= 50;
        moneyText.text = "$" + money.ToString();
        PlayerPrefs.SetInt("money", money);
    }


    public void LoseMoneyLarge()
    {
        money -= 100;
        moneyText.text = "$" + money.ToString();
        PlayerPrefs.SetInt("money", money);
    }


    public void taxes()
    {
        money -= 150;
        moneyText.text = "$" + money.ToString();
        PlayerPrefs.SetInt("money", money);

    }

    public void taxesButtonNotInteract()
    {
        taxesbutton.gameObject.GetComponent<Button>().interactable = false;
    }

    public void taxesButtonInteract()
    {
        taxesbutton.gameObject.GetComponent<Button>().interactable = true;
    }




}

