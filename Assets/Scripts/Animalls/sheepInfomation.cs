using Unity.VisualScripting;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class sheepInfomation : MonoBehaviour
{
    public float sheepAge;
    public bool sheepAlive;
    public float sheepHungerPercent;
    public int sheepPosition;

    [SerializeField] bool isChild;
    [SerializeField] bool isAdult;
    [SerializeField] bool isElder;

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
            // get sheep pos.
            Destroy(gameObject);
            // spawn sheep corpse
            // decrease sheep number
            
            // spawns dead sheep in spot of current sheep (Get sheep pos. destroys current object. spawns dead sheep.)
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
    }

    public void feedSheep()
    {
        // subtract 25 money from player
        // 
    }

}
