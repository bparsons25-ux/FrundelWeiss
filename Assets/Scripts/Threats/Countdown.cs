using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float remainingTime = 90f;

    [SerializeField] GameOver gameOver;

 

    // Update is called once per frame
    public void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }

        else if (remainingTime < 0)
        {
            remainingTime = 0;
            gameOver.gameIsOver = true; 
            timerText.color = Color.red;
        }
        
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = remainingTime.ToString();
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
