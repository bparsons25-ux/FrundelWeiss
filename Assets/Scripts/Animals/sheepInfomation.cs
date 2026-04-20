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
    [SerializeField] private OrganHarvesting organ;



    public void Start()
    {
        sheepAge = 0f;
        sheepAlive = true;
        sheepHungerPercent = 50f;
        isChild = true;

        
    }

    public void Update()
    {
        if (sheepAlive == true)
        {
            sheepAge += Time.deltaTime;
            sheepHungerPercent -= Time.deltaTime * 0.5f; // Hunger bar goes down by 0.5 / second 
        }

        else if (sheepAlive == false)
        {
            
            Destroy(gameObject);
            Instantiate(deadsheepPrefab, deathPosition.position, transform.rotation);
            // decrease sheep number
            
            
        }

        if (sheepAge > 300f)
        {
            isChild = false;
            // make it so then organs can be harvested harvested 
            // make it so then mesh changes from child to adult mesh
            isAdult = true;
        }

        if (sheepAge > 450f)
        {
            isAdult = false;
            // make it so then organ price decreases (incl. refrence to money script)
            isElder = true;

        }

        if (sheepAge > 510f)
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
    }



}
