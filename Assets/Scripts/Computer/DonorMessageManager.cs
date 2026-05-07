using UnityEngine;
using System.Collections;

public class DonorMessageManager : MonoBehaviour
{
    [Header("Player Messages")]

    [SerializeField] private GameObject playermessage1;
    [SerializeField] private GameObject playermessage2;
    [SerializeField] private GameObject playermessage3;
    [SerializeField] private GameObject playermessage4;


    [Header("Client Messages")]
    [SerializeField] private GameObject donormessage1;
    [SerializeField] private GameObject donormessage2;
    [SerializeField] private GameObject donormessage3;

    [Header("Player Message Interactions")]

    [SerializeField] private GameObject playerMessageInteraction1;
    [SerializeField] private GameObject playerMessageInteraction2;
    [SerializeField] private GameObject playerMessageInteraction3;
    [SerializeField] private GameObject playerMessageInteraction4;

    [Header("Convo Status")]

    [SerializeField] private GameObject canTypeText;
    [SerializeField] private GameObject cannotTypeText;
    [SerializeField] private GameObject waitToText;

    [Header("Client Reply Delay")]

    private float textDelayWait = 3f;


    private void Start()
    {
        donormessage1.gameObject.SetActive(false);
        playerMessageInteraction1.gameObject.SetActive(true);

        donormessage2.gameObject.SetActive(false);
        donormessage3.gameObject.SetActive(false);

        playerMessageInteraction2.gameObject.SetActive(false);
        playerMessageInteraction3.gameObject.SetActive(false);
        playerMessageInteraction4.gameObject.SetActive(false);

        canTypeText.gameObject.SetActive(true);
        cannotTypeText.gameObject.SetActive(false);
    }



    IEnumerator textDelay()
    {
        yield return new WaitForSeconds(textDelayWait);
    }

    public void DonorMessage2()
    {
        StartCoroutine(DonorReply2());
    }

    public void DonorMessage3()
    {
        StartCoroutine(DonorReply3());
    }

    public void DonorMessage4()
    {
        StartCoroutine(DonorReply4());
        

    }

    public void EndText()
    {
        StartCoroutine(DonorReply5());
        Debug.Log("Conversation Ended.");
    }


    IEnumerator DonorReply2()
    {
        canTypeText.gameObject.SetActive(false);
        playermessage1.gameObject.SetActive(true);
        playerMessageInteraction1.gameObject.SetActive(false);
        waitToText.gameObject.SetActive(true);
        yield return new WaitForSeconds(textDelayWait);
        waitToText.gameObject.SetActive(false);
        donormessage1.gameObject.SetActive(true);
        canTypeText.gameObject.SetActive(true);
        playerMessageInteraction2.gameObject .SetActive(true);
    }

    IEnumerator DonorReply3()
    {
        canTypeText.gameObject.SetActive(false);
        playermessage2.gameObject.SetActive(true);
        playerMessageInteraction2 .gameObject.SetActive(false);
        waitToText.gameObject.SetActive(true);
        yield return new WaitForSeconds(textDelayWait);
        waitToText.gameObject.SetActive(false);
        donormessage2.gameObject.SetActive(true);
        canTypeText.gameObject.SetActive(true);
        playerMessageInteraction3.gameObject.SetActive(true);
    }

    IEnumerator DonorReply4()
    {
        canTypeText.gameObject.SetActive(false);
        playermessage3.gameObject.SetActive(true);
        playerMessageInteraction3.gameObject.SetActive(false);
        waitToText.gameObject.SetActive(true);
        yield return new WaitForSeconds(textDelayWait);
        waitToText.gameObject.SetActive(false);
        donormessage3.gameObject.SetActive(true);
        canTypeText.gameObject .SetActive(true);
        playerMessageInteraction4.gameObject.SetActive(true);

    }

    IEnumerator DonorReply5()
    {
        canTypeText.gameObject.SetActive(false);
        waitToText.gameObject.SetActive(true);
        yield return new WaitForSeconds(textDelayWait);
        waitToText.gameObject.SetActive(false);
        playermessage4.gameObject.SetActive(true);
        playerMessageInteraction4 .gameObject.SetActive(false);
        cannotTypeText.gameObject.SetActive(true);
    }
}
