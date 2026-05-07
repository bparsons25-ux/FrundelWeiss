using System.Collections;
using UnityEngine;

public class startdaycount : MonoBehaviour
{
    [SerializeField] private GameObject loadingScreen;

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
        loadingScreen.gameObject.SetActive(true);
        yield return new WaitForSeconds(dayCountshow);
        loadingScreen.gameObject.SetActive(false);
    }

}
