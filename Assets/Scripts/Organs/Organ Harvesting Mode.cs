using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OrganHarvestingMode : MonoBehaviour
{
    [Header("Organ Harvesting Stats")]

    public float timeBeforeDeath;
    public float maxDeathTime = 60f;

    public float maxHarvestingTime;
    public static bool isHarvesting;

    [Header("Booleans")]

    public bool isHarevstingHeart;
    public bool isHarevstingLeftKidney;
    public bool isHarevstingRightKidney;
    public bool isHarevstingLiver;

    [Header("Maximum Organ Harvesting Countdowns")]

    public float maxHeartHarevstingTime = 50f ;
    public float maxLeftKidneyHarvestingTime = 20f;
    public float maxRightKidneyHarvestingTime = 20f;
    public float maxLiverKidneyHarvestingTime = 30f;

    [Header("Current Organ Harvesting Time")]

    public float currentHeartHarevstingTime = 50f;
    public float currentLeftKidneyHarvestingTime = 20f;
    public float currentRightKidneyHarvestingTime = 20f;
    public float currentLiverHarvestingTime = 30f;


    [Header("Object References")]

    public GameObject harvestingUserInterface;
    [SerializeField] private GeneralFunctions func;
    public GameObject sheep1;


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

    [Header("Organ Harvesting Bars")]

    public GameObject liverHarvestingBar;
    public GameObject heartHarvestingBar;
    public GameObject leftKidneyHarvestingBar;
    public GameObject rightKidneyHarvestingBar;

    [Header("Spawning Organs")]

    public static bool isSpawningHeart;
    public static bool isSpawningLiver;
    public static bool isSpawningLeftKidney;
    public static bool isSpawningRightKidney;

    public Transform sheepDeathPos;
    public GameObject sheepObject;

    [Header("other script References")]
    [SerializeField] private ObjectiveCounter objectivecounter;
    [SerializeField] private DayCounter daycounter;

    private bool sheepIsDead;


    public void Awake()
    {
        timeBeforeDeath = 3600f;
    }
    public void Start()
    {
        sheepIsDead = false;
    }





    public void Update()
    {
        if (isHarvesting == true)
        {
            timeBeforeDeath -= Time.deltaTime;
            UpdateDeathBar();
        }

        if (timeBeforeDeath < 0)
        {
            isHarvesting = false;
            harvestingUserInterface.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            func.CamUnlock();
            func.PlayerFree();
            

            if (daycounter.dayCount == 7)
            {

                objectivecounter.d7o3complete();
                sheepIsDead = true;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Q) && isHarvesting == true)
        {
            isHarvesting = false;
            harvestingUserInterface.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            func.CamUnlock();
            func.PlayerFree();

            if (daycounter.dayCount == 7)
            {
                objectivecounter.d7o3complete();
                sheepIsDead = true; 

                if (daycounter.dayCount == 7)
                {
                    sheep1.gameObject.SetActive(false);
                }
            }


        }

        // Heart Methods

        if (isHarevstingHeart == true)
        {
            currentHeartHarevstingTime -= Time.deltaTime;
            UpdateHeartBar();
        }

        if (currentHeartHarevstingTime < 0)
        {
            currentHeartHarevstingTime = 0;
            isHarevstingHeart = false;
            heartHarvestingBar.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("Heart Harvested!");
            isSpawningHeart = true;
        }

        // Liver Methods

        if (isHarevstingLiver == true)
        {
            currentLiverHarvestingTime -= Time.deltaTime;
            UpdateLiverBar();
        }

        if (currentLiverHarvestingTime < 0)
        {
            currentLiverHarvestingTime = 0;
            isHarevstingLiver = false;
            liverHarvestingBar.gameObject.SetActive(false);
            Debug.Log("Liver Harvested");
            Cursor.lockState = CursorLockMode.None;
            isSpawningLiver = true;
            

            
        }

        // Left Kidney Methods


        if (isHarevstingLeftKidney == true)
        {
            currentLeftKidneyHarvestingTime -= Time.deltaTime;
            UpdateLeftKidneyBar();
        }

        if (currentLeftKidneyHarvestingTime < 0)
        {
            currentLeftKidneyHarvestingTime = 0;
            isHarevstingLeftKidney = false;
            leftKidneyHarvestingBar.gameObject.SetActive(false);
            Debug.Log("Left Kidney Harvested!");
            Cursor.lockState = CursorLockMode.None;
            isSpawningLeftKidney = true;

            
        }

        // Right Kidney Methods

        if (isHarevstingRightKidney == true)
        {
            currentRightKidneyHarvestingTime -= Time.deltaTime;
            UpdateRightKidneyBar();
        }

        if (currentRightKidneyHarvestingTime < 0)
        {
            currentRightKidneyHarvestingTime = 0;
            isHarevstingRightKidney = false;
            rightKidneyHarvestingBar.gameObject.SetActive(false);
            Debug.Log("Right Kidney Harvested!");
            Cursor.lockState = CursorLockMode.None;
            isSpawningRightKidney = true;
           

            
        }

        if (sheepIsDead == true)
        {
            Instantiate(sheepObject, sheep1.transform.position, transform.rotation);
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
        liverHarvestingFill.fillAmount = currentLiverHarvestingTime / maxLiverKidneyHarvestingTime; 
    }

    public void ExtractHeart()
    {
        // step 1. Remove Organ, Step 2. Start Countdown, Step 3 - Activate Bar , Step 4 - Lock the mouse , Step 5. when Countdown ends - spawn in organ prefab and deactivate countdown bar , Step 6 - unlock mouse.  
        HeartButton.gameObject.SetActive(false);
        heartHarvestingBar.gameObject.SetActive(true);
        isHarevstingHeart = true;
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void ExtractLeftKidney()
    {
        // step 1. Remove Organ, Step 2. Start Countdown, Step 3 - Activate Bar , Step 4 - Lock the mouse , Step 5. when Countdown ends - spawn in organ prefab and deactivate countdown bar , Step 6 - unlock mouse.
        LeftKidneyButton.gameObject.SetActive(false);
        leftKidneyHarvestingBar.gameObject.SetActive(true);
        isHarevstingLeftKidney = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ExtractRightKidney()
    {
        // step 1. Remove Organ, Step 2. Start Countdown, Step 3 - Activate Bar , Step 4 - Lock the mouse , Step 5. when Countdown ends - spawn in organ prefab and deactivate countdown bar , Step 6 - unlock mouse.
        RightKidneyButton.gameObject.SetActive(false);
        rightKidneyHarvestingBar.gameObject.SetActive(true);
        isHarevstingRightKidney = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ExtractLiver()
    {
        // step 1. Remove Organ, Step 2. Start Countdown, Step 3 - Activate Bar , Step 4 - Lock the mouse , Step 5. when Countdown ends - spawn in organ prefab and deactivate countdown bar , Step 6 - unlock mouse.
        LiverButton.gameObject.SetActive(false);
        liverHarvestingBar.gameObject.SetActive(true);
        isHarevstingLiver = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void StartHarvesting()
    {
        isHarvesting = true;
        timeBeforeDeath = 60f;
        harvestingUserInterface.gameObject.SetActive(true);
        Debug.Log("Called Organ Harvest");
    }






}
