using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class countingFPS : MonoBehaviour
{
    public float timer, refresh, avgFramerate;
    public string display = "{0} FPS";
    public TextMeshProUGUI m_Text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float timelapse = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= timelapse;

        if(timer <=0) avgFramerate = (int) (1f / timelapse);
        m_Text.text = string.Format(display, avgFramerate.ToString());
        
    }
}
