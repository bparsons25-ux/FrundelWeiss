using UnityEngine;
using UnityEngine.UI;

public class Phone : Interactable
{
    public GameObject phonemenu;
    

    [SerializeField] float taxCooldown;
    [SerializeField] float taxCountdown;

    [SerializeField] bool taxPaid;
    [SerializeField] bool taxEvaded;

    // [SerializeField] GameObject Button;

    [SerializeField] MoneyManager mon;
    [SerializeField] Countdown count;

    




    protected override void Interact()
    {
        menuActive();

    }

    public void Start()
    {
        taxPaid = true;
        taxCooldown = 300f;
       
    }



    public void Update()
    {
        if (taxPaid = true && taxCooldown > 0)
        {
            taxCooldown -= Time.deltaTime; 
            

            // If the Player has paid their Tax and the tax cooldown is still happening - then keep on decreasing the time until the tax cooldown equals to zero.
        }

        else if (taxCooldown < 0)
        { 
            taxCooldown = 0;
            taxPaid = false;
            // if the taxcooldown reaches below 0 - then set the timer to 0 and then puts taxPaid to false
        }



        else if (taxPaid == false)
        {
            count.gameObject.SetActive(true);
        }

        int minutes = Mathf.FloorToInt(taxCooldown / 60);
        int seconds = Mathf.FloorToInt(taxCooldown % 60);
    }

    public void menuActive()
    {
        phonemenu.gameObject.SetActive(true);
    }

    public void payTax()
    {
        mon.taxes(); 
        taxPaid = true;
        taxEvaded = false;
        mon.LoseMoneyLarge();
        taxCooldown = 300f;
        count.remainingTime = 90;
        count.gameObject.SetActive(false);

    }



}
