using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PoliceOfficer : MonoBehaviour
{
    [SerializeField] private ObjectiveCounter counter;
    [SerializeField] private GeneralFunctions func;
    [SerializeField] private DayCounter dayCounter;
    [SerializeField] private MoneyManager moneyManager;
    [SerializeField] private FrontDoor frontDoor;
    [SerializeField] private PlayerMovement pm;
    

    [SerializeField] private GameObject transition;


    public GameObject talkingUI;
    public GameObject talkingoverall;
    public GameObject gameOverUI;
    public GameObject FinalPoliceText;
    public GameObject previousGameObject;

    public GameObject GameEndScreen;

    private bool canTalk;
  
    

    private float DestroyWaitTime = 5f;
    private float factswaitTime = 2f;

    private void Start()
    {
        canTalk = true;
        transition.gameObject.SetActive(false);
        GameEndScreen.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (canTalk == false)
        {
            talkingUI.SetActive(false);
            frontDoor.canOpen = false;
        }
    }


    public void TalkDay10()
    {
        if (dayCounter.dayCount == 10 && canTalk == true)
        {
            func.MouseLock();
            func.PlayerFreeze();
            func.CamLock();
            pm.PauseDeactivate();
            talkingUI.SetActive(true);
            talkingoverall.gameObject.SetActive(true);
        }
    }

    public void noTalkDay10()
    {
        if (dayCounter.dayCount == 10 && canTalk == false)
        {
            if (canTalk == false)
            {
                talkingUI.SetActive(false);
                func.MouseLock();
                func.CamUnlock();
                func.PlayerFree();
                pm.PauseActivate();


            }
        }
    }

    public void canTalkFalse()
    {
        canTalk = false;
        frontDoor.canOpen = false;
        frontDoor.gameObject.SetActive(true);
    }

    public void Unlock()
    {
        talkingoverall.gameObject.SetActive(false);
        func.MouseLock();
        func.CamUnlock();
        func.PlayerFree();
        pm.PauseActivate();
        canTalk = false;
    }




    IEnumerator GameOverwait()
    {
        Cursor.lockState = CursorLockMode.Locked;
        previousGameObject.gameObject.SetActive(false);
        FinalPoliceText.gameObject.SetActive(true);
        yield return new WaitForSeconds(DestroyWaitTime);
        FinalPoliceText.gameObject.SetActive(false);
        talkingoverall.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(true);
        yield return new WaitForSeconds(factswaitTime);
        func.CamLock();
        func.PlayerFreeze();
        func.ResetPos();
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
    }
    
    IEnumerator Transition()
    {
        SceneManager.LoadScene(2);
        func.CamLock();
        func.PlayerFreeze();
        transition.gameObject.SetActive(true);
        GameEndScreen.gameObject.SetActive(true);
        yield return new WaitForSeconds(factswaitTime);
        transition.gameObject.SetActive(false);
        yield return new WaitForSeconds(DestroyWaitTime);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        
    }
}
