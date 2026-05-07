using System.Collections;
using UnityEngine;

public class startdaycount : MonoBehaviour
{
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private GeneralFunctions functions;

    private float dayCountshow = 3;

    private void Start()
    {
        ShowDate();
    }
    public void ShowDate()
    {
        StartCoroutine(Date());
    }

    IEnumerator Date()
    {
        functions.PlayerFreeze();
        functions.CamLock();
        functions.ResetPos();
        loadingScreen.gameObject.SetActive(true);
        yield return new WaitForSeconds(dayCountshow);
        loadingScreen.gameObject.SetActive(false);
        functions.CamUnlock();
        functions.PlayerFree();
    }

}
