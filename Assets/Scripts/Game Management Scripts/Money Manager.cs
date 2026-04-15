using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using System.Numerics;

public class MoneyManager : MonoBehaviour
{

    public static MoneyManager instance;
    public TextMeshProUGUI moneyText;

    [SerializeField] PlayerMovement pm;

    int money = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        money = PlayerPrefs.GetInt("money", 0);
        moneyText.text = "$" + money.ToString();
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





}

