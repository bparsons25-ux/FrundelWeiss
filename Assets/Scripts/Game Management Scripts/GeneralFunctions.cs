using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralFunctions : MonoBehaviour
{
    [SerializeField] CamLook Look;
    [SerializeField] private GameOver GameOver;

    [SerializeField] private GameObject player;
    [SerializeField] private PlayerMovement playerMovement;
    public Transform spawnSpot;

    [SerializeField] GameObject pauseMenu;

    [SerializeField] private GameObject heart;
    [SerializeField] private GameObject liver;
    [SerializeField] private GameObject leftKidney;
    [SerializeField] private GameObject rightkidney;

    [SerializeField] private Transform playerCamPos;

    [SerializeField] private CharacterController controller;

    private void Start()
    {


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
        Look.xSensitivity = 35f;
        Look.ySenstivity = 35f;
      

    }

    public void TriggerGameOver()
    {
        pauseMenu.SetActive(false);
        GameOver.gameIsOver = true;
        playerMovement.PauseDeactivate();


    }

    public void PlayerFreeze()
    {
        playerMovement.MoveDeactiavte();
    }

    public void PlayerFree()
    {
        playerMovement.MoveActiavte();
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ResetPos()
    {
        player.transform.position = spawnSpot.transform.position;
    }




}
