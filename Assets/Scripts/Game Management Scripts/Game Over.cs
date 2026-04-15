using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject deathScreenCanvas;
    public bool gameIsOver = false;
    [SerializeField] MoneyManager MM;


    public void Update()
    {
        if (gameIsOver == true)
        {
            GameOverState();
        }
    }
    public void GameOverState()
    {
        Debug.Log("Dead!");
        Time.timeScale = 0F;
        deathScreenCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
        gameIsOver = false;
        Cursor.lockState = CursorLockMode.None;
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.None;
         
        gameIsOver = false;

    }

}
