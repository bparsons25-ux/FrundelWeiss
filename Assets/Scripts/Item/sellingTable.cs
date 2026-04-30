using UnityEngine;

public class sellingTable : MonoBehaviour
{
    [SerializeField] NPCsystem npcsystem;
    [SerializeField] 

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Heart Jar") && collision.CompareTag("Left Kidney") && npcsystem.fatCustomerIsActive == true)  // Fat Customer #1 - Left Kidney and Heart
        {
            npcsystem.SoldHeart();
            npcsystem.SoldLeftKidney();
            NPCsystem.hasSold = true; // moves the NPC back towards despawn position 
        }

        if (collision.CompareTag("Left Kidney") && collision.CompareTag("Right Kidney") && npcsystem.skinnyCustomerIsActive == true) // Skinny Cutsomer #1 - Left and Right Kidney
        {
            npcsystem.SoldLeftKidney();
            npcsystem.SoldRightKidney();
            NPCsystem.hasSold = true;  // moves the NPC back towards despawn position
        }

        if (collision.CompareTag("Liver") && npcsystem.fatCustomer2IsActive == true) // Fat Customer 2# - Liver
        {
            npcsystem.SoldLiver();
            NPCsystem.hasSold = true; // moves the NPC back towards despawn position
        }

        if (collision.CompareTag("Heart") && collision.CompareTag("Liver") && npcsystem.skinnyCustomer2IsActive == true)
        {
            npcsystem.SoldHeart();
            npcsystem.SoldLiver();
            NPCsystem.hasSold = true;
        }
    }
}
