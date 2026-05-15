using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextingScript : MonoBehaviour
{
    public float lettersTyped;
    public float maxLetterToType;

    
    public GameObject sendButton;

    [SerializeField] private Image TextMessageFill;

    [SerializeField] private ComputerAudioManager ComputerAudioManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lettersTyped = 0;
        
    }

    private void Update()
    {
        if (lettersTyped < maxLetterToType)
        {
            sendButton.gameObject.GetComponent<Button>().interactable = false;

            if (Input.anyKeyDown)
            {
                Type();
                ComputerAudioManager.Type();
            }
        }


        if (lettersTyped == maxLetterToType)
        {
            lettersTyped = maxLetterToType;
            sendButton.gameObject.GetComponent<Button>().interactable = true;
        }

        UpdateTextBar();
    }

    public void Type()
    {
        lettersTyped++;

    }

    public void UpdateTextBar()
    {
        TextMessageFill.fillAmount = lettersTyped / maxLetterToType;
    }

}
