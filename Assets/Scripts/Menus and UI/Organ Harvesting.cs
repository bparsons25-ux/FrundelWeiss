using UnityEngine;

public class OrganHarvesting : MonoBehaviour
{
    public GameObject organMenu;

    public void Harvest()
    {
        organMenu.gameObject.SetActive(true);

    }

    public void Leave()
    {
        organMenu.gameObject.SetActive(false);

    }


}
