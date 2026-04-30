using Unity.VisualScripting;
using UnityEngine;

public class NPCmovement : MonoBehaviour
{
    [Header("Waypoint Script References")]

    [SerializeField] private WaypointMovement WaypointMovement1;
    [SerializeField] private GoHomeWaypointMovement WaypointMovement2;
    [SerializeField] private NPCsystem NPCsystem;

    [Header("NPC Position Checking Booleans")]

    public static bool isAtSpawn;
    public static bool isAtSale;
    public static bool isAtDespawn;
    

    



    private void Start()
    {
        isAtSpawn = true;
        isAtSale = false;
        isAtDespawn = false;

        WaypointMovement1.enabled = false;
        WaypointMovement2.enabled = false;


    }

    private void Update()
    {
        if (isAtSpawn == true)
        {
            WaypointMovement1.enabled = true;
        }

        if (isAtSale == true)
        {
            WaypointMovement1.enabled = false;
            
        }

        if (NPCsystem.hasSold == true)
        {
            WaypointMovement2.enabled = true;
        }





        if (isAtDespawn == true)
        {
            NPCsystem.saleIsDone = true;
            NPCsystem.hasSold = false;
            Destroy(gameObject);
            
        }

    }


}
