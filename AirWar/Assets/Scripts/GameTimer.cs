using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Text timerText;
    public Text gameOverText;
    private float startTime = 120f;

    private float timeRemaining;
    private bool timerRunning = true;

    void Start()
    {
        timeRemaining = startTime;
        UpdateTimer();
        
    }

    void Update()
    {
        if (timerRunning)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                timerRunning = false;
                TimerEnd();
            }

            UpdateTimer();
        }
        
    }

    void UpdateTimer()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void TimerEnd()
    {
        // MonoBehaviour[] allScripts = FindObjectsOfType<MonoBehaviour>();
        // foreach (MonoBehaviour script in allScripts)
        // {
        //     script.enabled = false;
        // }

        MovimientoBateria movBateria = FindObjectOfType<MovimientoBateria>();
        if (movBateria != null)
        {
            movBateria.enabled = false;
        }

        Bateria bateria = FindObjectOfType<Bateria>();
        if(bateria != null)
        {
            bateria.enabled = false;
        }

        gameOverText.text = "GAME OVER";
    }
}
