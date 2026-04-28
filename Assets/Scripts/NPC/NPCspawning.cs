using UnityEngine;

public class NPCspawning : MonoBehaviour
{
    public GameObject[] npcsToSpawn;
    public Transform spawnPos;


    public float timeToNextSpawn;
    public float timesinceLastSpawn;

    public float minSpawnTime = 120f;
    public float maxSpawnTime = 180f;

    public bool canSpawnNPC;

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
    }

    private void Update()
    {
        timesinceLastSpawn = timesinceLastSpawn + Time.deltaTime; // timeSinceLastSpawn now increases in seconds

        if (timesinceLastSpawn > timeToNextSpawn && canSpawnNPC == true)
        {
            int selection = Random.Range (0, npcsToSpawn.Length);

            Instantiate(npcsToSpawn[selection], spawnPos.position, transform.rotation ); // note: MAKE THE SPAWN POS OBJECT FACE FORWARDS

            timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime );
            canSpawnNPC = false;
            timesinceLastSpawn = 0.0f;
        }
    }

    private void OnceSold()
    {
        canSpawnNPC = true;
    }



}
