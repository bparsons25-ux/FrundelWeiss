using UnityEngine;

public class sellingTable : MonoBehaviour
{
    [SerializeField] NPCsystem npcsystem;
    [SerializeField] 

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Heart Jar") && collision.CompareTag("Left Kidney Jar") && npcsystem.fatCustomerIsActive == true)  // Fat Customer #1 - Left Kidney and Heart
        {
            npcsystem.SoldHeart();
            npcsystem.SoldLeftKidney();
            Destroy(collision.gameObject);
            NPCsystem.hasSold = true; // moves the NPC back towards despawn position 
        }

        if (collision.CompareTag("Left Kidney Jar") && collision.CompareTag("Right Kidney Jar") && npcsystem.skinnyCustomerIsActive == true) // Skinny Cutsomer #1 - Left and Right Kidney
        {
            npcsystem.SoldLeftKidney();
            npcsystem.SoldRightKidney();
            Destroy(collision.gameObject);
            NPCsystem.hasSold = true;  // moves the NPC back towards despawn position
        }

        if (collision.CompareTag("Liver Jar") && npcsystem.fatCustomer2IsActive == true) // Fat Customer 2# - Liver
        {
            npcsystem.SoldLiver();
            Destroy(collision.gameObject);
            NPCsystem.hasSold = true; // moves the NPC back towards despawn position
        }

        if (collision.CompareTag("Heart Jar") && collision.CompareTag("Liver Jar") && npcsystem.skinnyCustomer2IsActive == true)
        {
            npcsystem.SoldHeart();
            npcsystem.SoldLiver();
            Destroy(collision.gameObject);
            NPCsystem.hasSold = true;
        }
    }
}
