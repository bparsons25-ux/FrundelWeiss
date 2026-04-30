using UnityEngine;

public class spawner : MonoBehaviour
{
    [Header("Spawning Organs")]

    [SerializeField] Transform heartPos;
    public GameObject heartPrefab;

    [SerializeField] Transform liverPos;
    public GameObject liverPrefab;

    [SerializeField] Transform leftKidneyPos;
    public GameObject leftKidneyPrefab;

    [SerializeField] Transform rightKidneyPos;
    public GameObject rightKidneyPrefab;

    



    public void Update()
    {
        if (OrganHarvestingMode.isSpawningHeart == true)
        {
            spawnHeart();
            OrganHarvestingMode.isSpawningHeart = false;
        }

        if (OrganHarvestingMode.isSpawningLiver == true)
        {
            spawnLiver();
            OrganHarvestingMode.isSpawningLiver = false;
        }

        if (OrganHarvestingMode.isSpawningLeftKidney == true)
        {
            spawnLeftKidney();
            OrganHarvestingMode.isSpawningLeftKidney = false;
        }

        if (OrganHarvestingMode.isSpawningRightKidney == true)
        {
            spawnRightKidney();
            OrganHarvestingMode.isSpawningRightKidney=false;
        }


    }

    public void spawnHeart()
    {
        Instantiate(heartPrefab, heartPos.transform.position, transform.rotation);
        Debug.Log("Heart spawned");
    }

    public void spawnLiver()
    {
        Instantiate(liverPrefab, liverPos.transform.position, transform.rotation);
        Debug.Log("Liver spawned");
    }

    public void spawnLeftKidney()
    {
        Instantiate(leftKidneyPrefab, leftKidneyPos.transform.position, transform.rotation);
        Debug.Log("Left Kidney");
    }

    public void spawnRightKidney()
    {
        Instantiate(rightKidneyPrefab, rightKidneyPos.transform.position, transform.rotation);
        Debug.Log("Right Kidney");
    }

}
