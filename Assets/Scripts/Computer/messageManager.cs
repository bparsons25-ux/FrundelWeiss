using System.Collections;
using UnityEngine;

public class messageManager : MonoBehaviour
{
    [Header("Player Messages")]

    [SerializeField] private GameObject playermessage1;
    [SerializeField] private GameObject playermessage2;
    [SerializeField] private GameObject playermessage3;


    [Header("Client Messages")]
    [SerializeField] private GameObject clientmessage1;
    [SerializeField] private GameObject clientmessage2;
    [SerializeField] private GameObject clientmessage3;
    [SerializeField] private GameObject clientmessage4;

    [Header("Player Message Interactions")]

    [SerializeField] private GameObject playerMessageInteraction1;
    [SerializeField] private GameObject playerMessageInteraction2;
    [SerializeField] private GameObject playerMessageInteraction3;

    [Header("Convo Status")]

    [SerializeField] private GameObject canTypeText;
    [SerializeField] private GameObject cannotTypeText;

    [Header("Client Reply Delay")]

    private float textDelayWait = 3f;

    [SerializeField] ComputerAudioManager computerAudioManager;


    private void Start()
    {
        clientmessage1.gameObject.SetActive(true);
        playerMessageInteraction1.gameObject.SetActive(true);
        
        clientmessage2.gameObject.SetActive(false);
        clientmessage3.gameObject.SetActive(false);

        playerMessageInteraction2.gameObject.SetActive(false);
        playerMessageInteraction3.gameObject.SetActive(false);

        canTypeText.gameObject.SetActive(true);
        cannotTypeText.gameObject.SetActive(false);
    }

    IEnumerator textDelay()
    {
        yield return new WaitForSeconds(textDelayWait);
    }

    public void ClientMessage2()
    {
        StartCoroutine(ClientReply2());
    }

    public void ClientMessage3()
    {
        StartCoroutine(ClientReply3());
    }

    public void Endtext()
    {
        StartCoroutine(ClientReply4());
        Debug.Log("Conversation Ended.");
        
    }

    IEnumerator ClientReply2()
    {
        playerMessageInteraction1.gameObject.SetActive(false);
        yield return new WaitForSeconds(textDelayWait);
        clientmessage2.gameObject.SetActive(true);
        computerAudioManager.MessageRecieved();
        playerMessageInteraction2.gameObject.SetActive(true);
    }

    IEnumerator ClientReply3()
    {
        playerMessageInteraction2.gameObject.SetActive(false);
        yield return new WaitForSeconds(textDelayWait);
        clientmessage3.gameObject.SetActive(true);
        computerAudioManager.MessageRecieved();
        playerMessageInteraction3.gameObject.SetActive(true);
    }

    IEnumerator ClientReply4()
    {
        playerMessageInteraction3.gameObject.SetActive(false);
        canTypeText.gameObject.SetActive(false);
        cannotTypeText.gameObject.SetActive(true);
        yield return new WaitForSeconds(textDelayWait);
        clientmessage4.gameObject.SetActive(true);
        computerAudioManager.MessageRecieved();

    }






}
