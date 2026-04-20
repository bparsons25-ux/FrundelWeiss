using UnityEngine;
using UnityEngine.UI;

public class OrganHarvestingMode : MonoBehaviour
{
    [Header("Organ Harvesting Stats")]

    public float timeBeforeDeath;
    public float maxDeathTime = 60f;

    public float maxHarvestingTime;
    public static bool isHarvesting;

    [Header("Maximum Organ Harvesting Countdowns")]

    public float maxHeartHarevstingTime = 50f ;
    public float maxLeftKidneyHarvestingTime = 20f;
    public float maxRightKidneyHarvestingTime = 20f;
    public float maxLiverKidneyHarvestingTime = 30f;

    [Header("Current Organ Harvesting Time")]

    public float currentHeartHarevstingTime = 50f;
    public float currentLeftKidneyHarvestingTime = 20f;
    public float currentRightKidneyHarvestingTime = 20f;
    public float currentLiverKidneyHarvestingTime = 30f;


    [Header("Object References")]

    public GameObject sheepPrefab;
    public GameObject harvestingUserInterface;
    [SerializeField] private sheepInfomation sInfo;

    [Header("User Interface Objects")]

    public GameObject HeartButton;
    public GameObject LiverButton;
    public GameObject LeftKidneyButton;
    public GameObject RightKidneyButton;

    [Header("Life Reamaining Bar")]

    [SerializeField] private Image deathbarFill;
    [SerializeField] private Image liverHarvestingFill;
    [SerializeField] private Image heartHarvestingFill;
    [SerializeField] private Image leftKidneyHarvestingFill;
    [SerializeField] private Image rightKidneyHarvestingFill;

    [Header("Spawning Organs")]

    public Transform heartPos;
    public GameObject heartPrefab;

    public Transform liverPos;
    public GameObject liverPrefab;

    public Transform leftKidneypos;
    public GameObject leftKidneyPrefab;

    public Transform rightKidneypos;
    public GameObject rightKidneyPrefab;


    private void Awake()
    {
        isHarvesting = true;
        timeBeforeDeath = 60f;

    }

    public void Update()
    {
        if (isHarvesting == true)
        {
            timeBeforeDeath -= Time.deltaTime;
            UpdateDeathBar();
            harvestingUserInterface.gameObject.SetActive(true);
            
        }

        if (timeBeforeDeath == 0 )
        {
            isHarvesting = false;
            harvestingUserInterface.gameObject.SetActive(false);
            sInfo.sheepAlive = false;
        }

    }

    private void UpdateDeathBar()
    {
        deathbarFill.fillAmount = timeBeforeDeath / maxDeathTime;
    }

    private void UpdateLeftKidneyBar()
    {
        leftKidneyHarvestingFill.fillAmount = currentLeftKidneyHarvestingTime / maxLeftKidneyHarvestingTime;
    }

    private void UpdateRightKidneyBar()
    {
        rightKidneyHarvestingFill.fillAmount = currentRightKidneyHarvestingTime / maxRightKidneyHarvestingTime;
    }

    private void UpdateHeartBar()
    {
        heartHarvestingFill.fillAmount = currentHeartHarevstingTime / maxHeartHarevstingTime;
    }

    private void UpdateLiverBar()
    {
        liverHarvestingFill.fillAmount = currentLiverKidneyHarvestingTime / maxLiverKidneyHarvestingTime; 
    }

    private void ExtractHeart()
    {
        // step 1. Remove Organ, Step 2. Start Countdown, Step 3 - Activate Bar , Step 4 - Lock the mouse , Step 5. when Countdown ends - spawn in organ prefab and deactivate countdown bar , Step 6 - unlock mouse.  
    }

    private void ExtractLeftKidney()
    {
        // step 1. Remove Organ, Step 2. Start Countdown, Step 3 - Activate Bar , Step 4 - Lock the mouse , Step 5. when Countdown ends - spawn in organ prefab and deactivate countdown bar , Step 6 - unlock mouse.
    }

    private void ExtractRightKidney()
    {
        // step 1. Remove Organ, Step 2. Start Countdown, Step 3 - Activate Bar , Step 4 - Lock the mouse , Step 5. when Countdown ends - spawn in organ prefab and deactivate countdown bar , Step 6 - unlock mouse.
    }

    private void ExtractLiver()
    {
        // step 1. Remove Organ, Step 2. Start Countdown, Step 3 - Activate Bar , Step 4 - Lock the mouse , Step 5. when Countdown ends - spawn in organ prefab and deactivate countdown bar , Step 6 - unlock mouse.
    }




}
