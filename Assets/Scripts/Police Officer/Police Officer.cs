using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PoliceOfficer : MonoBehaviour
{
    [SerializeField] private ObjectiveCounter counter;
    [SerializeField] private GeneralFunctions func;
    [SerializeField] private DayCounter dayCounter;
    [SerializeField] private MoneyManager moneyManager;
    [SerializeField] private FrontDoor frontDoor;


    public GameObject talkingUI;
    public GameObject talkingoverall;

    private bool canTalk;

    private float DestroyWaitTime = 3f;

    private void Start()
    {
        canTalk = true;
    }


    public void TalkDay10()
    {
        if (dayCounter.dayCount == 10 && canTalk == true)
        {
            func.MouseLock();
            func.PlayerFreeze();
            func.CamLock();
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
                func.MouseUnlock();
                func.CamUnlock();
                func.PlayerFreeze();
            }
        }
    }

    public void canTalkFalse()
    {
        canTalk = false;
        frontDoor.canOpen = false;
    }

    public void Unlock()
    {
        talkingoverall.gameObject.SetActive(false);
        func.MouseUnlock();
        func.CamUnlock();
        func.PlayerFreeze();
        canTalk = false;
        StartCoroutine(DestroyWait());

    }

    IEnumerator DestroyWait()
    {
        yield return new WaitForSeconds(DestroyWaitTime);
        Destroy(gameObject);
    }
    
}
