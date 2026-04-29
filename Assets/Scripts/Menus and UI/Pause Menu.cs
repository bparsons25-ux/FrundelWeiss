using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    public void home()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadSceneAsync(0);
    }

    
 
}
