using TMPro;
using Unity.VisualScripting;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.UI;

public class sheepInfomation : MonoBehaviour
{

    [ Header ("Sheep Stats")]
    public float sheepAge;
    public bool sheepAlive;
    public float sheepHungerPercent;
    public int sheepPosition;
    public int sheepCount;
    public bool sheepActive;
    public GameObject HarvestButton;

    [ Header ("Sheep Death Postioning")]

    public Transform deathPosition;
    public GameObject deadsheepPrefab;

    // [SerializeField] GameObject harvestButton;
    // [SerializeField] GameObject FeedButton;

    [ Header ("Sheep Age Settings")]

    [SerializeField] bool isChild;
    [SerializeField] bool isAdult;
    [SerializeField] bool isElder;

    [Header ("Script References")]

    [SerializeField] private MoneyManager mon;



    [Header("Text References")]
    public TextMeshProUGUI ageText;
    public TextMeshProUGUI hungerText;



    public void Start()
    {
        sheepAge = 0f;
        sheepAlive = true;
        sheepHungerPercent = 100f;
        isChild = true;
        sheepActive = false;


        ageText.text = "Age:" + sheepAge.ToString();
        hungerText.text = "Hunger" + sheepHungerPercent.ToString();
        
    }

    public void Update()
    {
        if (sheepAlive == true)
        {
            sheepAge += Time.deltaTime;
            ageText.text = "Age:" + sheepAge.ToString();
                        
            sheepHungerPercent -= Time.deltaTime * 0.25f; // Hunger bar goes down by 0.25 / second 
            hungerText.text = "Hunger" + sheepHungerPercent.ToString();

        }

        else if (sheepAlive == false)
        {
            
            //Destroy(gameObject);
            //Instantiate(deadsheepPrefab, deathPosition.position, transform.rotation);
            // decrease sheep number
            
            
        }

        if (sheepAge > 120f)
        {
            isChild = false;
            // make it so then organs can be harvested harvested 
            // make it so then mesh changes from child to adult mesh
            isAdult = true;
        }

        if (sheepAge > 300f)
        {
            isAdult = false;
            // make it so then organ price decreases (incl. refrence to money script)
            isElder = true;

        }

        if (sheepAge > 420f)
        {
            isElder = false;
            sheepAlive = false;
        }

        if (sheepHungerPercent < 0f)
        {
            sheepAlive = false;
        }

        if (sheepHungerPercent > 100f)
        {
            sheepHungerPercent = 100f;

        }

        if (isChild == true)
        {
            //HarvestButton.gameObject.GetComponent<Button>().interactable = false;
        }

        else if (isAdult == true)
        {
            //HarvestButton.gameObject.GetComponent<Button>().interactable = true;
        }

        else if (isElder == true)
        {
            //HarvestButton.gameObject.GetComponent<Button>().interactable = true;
        }









    }

    public void feedSheep()
    {
        mon.money -= 25;
        sheepHungerPercent += 25f;
        mon.moneyText.text = "$" + mon.money.ToString();
        PlayerPrefs.SetInt("money", mon.money);
    }

}
