using UnityEngine;

public class GeneralFunctions : MonoBehaviour
{
    [SerializeField] CamLook Look;
    [SerializeField] PlayerMovement pm;
    [SerializeField] private GameOver GameOver;

    [SerializeField] private GameObject player;

    [SerializeField] GameObject pauseMenu;

    [SerializeField] private GameObject heart;
    [SerializeField] private GameObject liver;
    [SerializeField] private GameObject leftKidney;
    [SerializeField] private GameObject rightkidney;

    [SerializeField] private Transform playerCamPos;

    [SerializeField] private CharacterController controller;

    private void Start()
    {
        pm  = GetComponent<PlayerMovement>();
        controller = player.GetComponent<CharacterController>();

    }


    public void MouseLock()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void MouseUnlock()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void CamLock()
    {
        Look.xSensitivity = 0f;
        Look.ySenstivity = 0f;


    }

    public void CamUnlock()
    {
        Look.xSensitivity = 20f;
        Look.ySenstivity = 20f;
      

    }

    public void TriggerGameOver()
    {
        pauseMenu.SetActive(false);
        GameOver.gameIsOver = true;


    }

    public void PlayerFreeze()
    {
        controller.enabled = false;
    }

    public void PlayerFree()
    {
        controller.enabled = true;
    }


}
