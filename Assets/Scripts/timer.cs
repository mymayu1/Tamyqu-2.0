using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    
    public TextMeshProUGUI timertext;
    public float startTime;
    public float timerInMinutes;
    public float timerInSeconds;

    public GameObject GameOverScreen;
    public AudioSource AudioSource;
    private float t;


    private bool timeout = false;
    // TODO = if enemies all die stop the time;

    void Start()
    {
        startTime = 64f;
        t=startTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeout)
            return;
         t -= Time.deltaTime;
        string minutes = (((int)t / 60)).ToString();
        string seconds = ((int)t % 60).ToString("f0");
       
    
         timertext.text = minutes + ":" + seconds;

        if (t < 1)
        {   
            GameOverScreen.SetActive(true);

            AudioSource.Stop();
            Time.timeScale = 0f;
            Debug.Log("time out");
            Timeout();

        }       

    }
    public void Timeout()
    {  timertext.text="0:0";
        soundmanager.PlaySound("gameover");
        timeout = true;
        timertext.color = Color.red;
    }



}
