using UnityEngine;

public class OrganJars : MonoBehaviour
{

    public Transform jarPos;

    [SerializeField] private GameObject heartJar;
    [SerializeField] private GameObject liverJar;
    [SerializeField] private GameObject leftKidenyJar;
    [SerializeField] private GameObject rightKidneyJar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // if heart collides with top of jar (Collider) - then destroy jar and heart objects and instantiate a heart filled jar object in its place. 
    // if liver collides with top of jar (Collider) - then destroy jar and liver objects and instantiate a liver filled jar object in its place. 
    // if left kidney collides with top of jar (Collider) - then destroy jar and left kidney objects and instantiate a left kidney filled jar object in its place. 
    // if right kidney collides with top of jar (Collider) - then destroy jar and right kidney objects and instantiate a right kidney filled jar object in its place. 

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Heart"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(heartJar, jarPos.position, transform.rotation);
        }

        if (collision.CompareTag("Heart"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(liverJar, jarPos.position, transform.rotation);
        }

        if (collision.CompareTag("leftKidney"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(leftKidenyJar, jarPos.position, transform.rotation);
        }
        if (collision.CompareTag("rightKidney"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(rightKidneyJar, jarPos.position, transform.rotation);
        }
    }


}
