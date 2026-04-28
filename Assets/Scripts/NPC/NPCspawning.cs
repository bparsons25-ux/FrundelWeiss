using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class NPCspawning : MonoBehaviour
{
    public GameObject[] npcsToSpawn;
    public Transform spawnPos;


    public float timeToNextSpawn;
    public float timesinceLastSpawn;

    public float minSpawnTime = 30f;
    public float maxSpawnTime = 60f;

    public bool canSpawnNPC;

    [SerializeField] private GameObject BlankNPC;
    private EmptyNPC emptyNPC;

    // 60 = 1 min
    // 90 = 1.5 min
    // 120 = 2 min
    // 150 = 2.5 min
    // 180 = 3 min
    // 210 = 3.5 min
    // 240 = 4 min
    // 270 = 4.5 min
    // 300 = 5 min




    private void Start()
    {
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime); // Returns a Random Time for the enemies to Spawn
        canSpawnNPC = true; 
        emptyNPC = BlankNPC.GetComponent<EmptyNPC>();
    }

    private void Update()
    {
        timesinceLastSpawn = timesinceLastSpawn + Time.deltaTime; // timeSinceLastSpawn now increases in seconds

        if (timesinceLastSpawn > timeToNextSpawn && canSpawnNPC == true)
        {
            int selection = Random.Range (0, npcsToSpawn.Length);

            Instantiate(npcsToSpawn[selection], spawnPos.position, transform.rotation ); // note: MAKE THE SPAWN POS OBJECT FACE FORWARDS

            
            canSpawnNPC = false;
            
        }

    }

    public void OnceSold()
    {
        canSpawnNPC = true;
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
        timesinceLastSpawn = 0.0f;
    }

    public void BoostTime()
    {
        timesinceLastSpawn = timeToNextSpawn;
        timeToNextSpawn += Time.deltaTime;
    }

    public void DestroyBlank()
    {
        if (emptyNPC.isBlank == true)
        {
            Destroy(emptyNPC.gameObject);
            emptyNPC.isBlank = false;
            BoostTime();
            Debug.Log("Blank Object Destroyed");
        }
    }
    
   



}
