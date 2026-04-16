using UnityEngine;

public class GeneralFunctions : MonoBehaviour
{
    [SerializeField] CamLook Look;
    [SerializeField] PlayerMovement pm;
    [SerializeField] private GameOver GameOver;

    [SerializeField] GameObject pauseMenu;

    private void Start()
    {
        pm  = GetComponent<PlayerMovement>();
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
        //pm.speed = 0f;
        //pm.jumpHeight = 0f;
    }

    public void PlayerFree()
    {
        //pm.speed = 10f;
        //pm.jumpHeight = 0.75f;
    }

}
