using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameUIManager : MonoBehaviour
{
    [Header("Script References")]
    [SerializeField] HealthManager playerHealth;
    [SerializeField] TimeManager tm;
    [Header("Texts")]
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI timerText;
    string calculatedMinute;
    string calculatedSecond;
    void Update()
    {
        healthText.text = "HP " + playerHealth.health;
        scoreText.text = "Score " + PlayerController.score;
        timeText.text = calculatedMinute + ":" + calculatedSecond;
        timerText.text = "" + Mathf.RoundToInt(tm.timer);
        if (!tm.isTimerActive)
        {
            timerText.gameObject.SetActive(false);
            tm.ResetTimer();
        }

        FormatTime();
    }

    private void FormatTime()
    {
        if (tm.minutes < 10)
        {
            calculatedMinute = "0" + Mathf.RoundToInt(tm.minutes);
        }
        else
        {
            calculatedMinute = "" + Mathf.RoundToInt(tm.minutes);
        }
        if (tm.seconds < 10)
        {
            calculatedSecond = "0" + Mathf.RoundToInt(tm.seconds);
        }
        else
        {
            calculatedSecond = "" + Mathf.RoundToInt(tm.seconds);
        }
    }
}
