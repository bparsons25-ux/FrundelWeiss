using UnityEngine;

public class OrganHarvesting : MonoBehaviour
{
    public GameObject organMenu;

    private InputManager InputManager;

    public void Start()
    {
        InputManager = GetComponent<InputManager>();
    }

    public void Harvest()
    {
        organMenu.gameObject.SetActive(true);

    }

    public void Leave()
    {
        organMenu.gameObject.SetActive(false);

    }


}
