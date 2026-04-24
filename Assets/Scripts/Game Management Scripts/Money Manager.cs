using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using System.Numerics;

public class MoneyManager : MonoBehaviour
{

    public static MoneyManager instance;
    public TextMeshProUGUI moneyText;

    [Header ("Script References")]

    [SerializeField] PlayerMovement pm;
    [SerializeField] Countdown countdown;
    [SerializeField] sheepInfomation shinfo;


    public int money;

    private void Awake()
    {
        
        instance = this;
    }

    void Start()
    {
        
        money = PlayerPrefs.GetInt("money", 150);
        moneyText.text = "$" + money.ToString();

    }

    void Update()
    {
        if (money < 0)
        {
            
            countdown.gameObject.SetActive(true);
            moneyText.color = Color.red;
        }

        else if (money > 0)
        {
            countdown.remainingTime = 180f;
            countdown.gameObject.SetActive(false);
            moneyText.color = Color.white;
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

    public void PayForFood()
    {
        shinfo.sheepHungerPercent += 25f;
        money -= 25;
    }

    public void taxes()
    {
        money -= 150;
    }




}

