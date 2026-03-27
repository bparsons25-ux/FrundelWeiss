using UnityEngine;

public class Sheep : Interactable
{
    public GameObject sheepinteract;
    private CamLook cam;


    private void Start()
    {
        cam = GetComponent<CamLook>();
    }

    private void Update()
    {
        
    }

    protected override void Interact()
    {
        sheepinteract.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        cam.gameObject.SetActive(false);
    }




}
