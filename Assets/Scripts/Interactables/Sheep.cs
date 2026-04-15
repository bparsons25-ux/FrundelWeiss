using UnityEngine;

public class Sheep : Interactable
{
    public GameObject sheepinteract;
    private Camera cam;

    


    private void Start()
    {
        cam = GetComponent<CamLook>().cam;
    }

    private void Update()
    {
        
    }

    protected override void Interact()
    {
        sheepinteract.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        
    }

    public void Leave()
    {
        sheepinteract.SetActive(false);
    }




}
