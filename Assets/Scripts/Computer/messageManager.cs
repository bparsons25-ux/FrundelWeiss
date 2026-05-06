using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Rendering;

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

    [Header("Client Reply Delay")]

    private float textDelayWait = 3f;


    private void Start()
    {
        clientmessage1.gameObject.SetActive(true);
        playerMessageInteraction1.gameObject.SetActive(true);
        
        clientmessage2.gameObject.SetActive(false);
        clientmessage3.gameObject.SetActive(false);

        playerMessageInteraction2.gameObject.SetActive(false);
        playerMessageInteraction3.gameObject.SetActive(false);
    }

    IEnumerator textDelay()
    {
        yield return new WaitForSeconds(textDelayWait);
    }

    public void ClientMessage2()
    {
        StartCoroutine(textDelay());
        clientmessage2.gameObject.SetActive(true);
        playerMessageInteraction1.gameObject.SetActive(false);
        playerMessageInteraction2.gameObject.SetActive(true);
    }

    public void ClientMessage3()
    {
        StartCoroutine(textDelay());
        clientmessage3.gameObject.SetActive(true);
        playerMessageInteraction2.gameObject.SetActive(false);
        playerMessageInteraction3.gameObject.SetActive(true);
    }

    public void Endtext()
    {
        playerMessageInteraction3.gameObject.SetActive(false);
        Debug.Log("Conversation Ended.");
        
    }






}
