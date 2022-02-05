using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerRigidbody;
    [SerializeField] int gravityScaleAmount;
    [SerializeField] float defaultTimer;
    public float timer;
    public bool isTimerActive;
    public float seconds;
    public float minutes;
    void Awake()
    {
        playerRigidbody.gravityScale = 0;
        timer = defaultTimer;
        isTimerActive = true;
    }
    private void Update()
    {
        StartTimer();
        StopTimer();
        CalculateTimeSinceStart();
    }

    private void CalculateTimeSinceStart()
    {
        if (!isTimerActive)
        {
            seconds += Time.deltaTime;
            if (seconds >= 60)
            {
                minutes++;
                seconds = 0;
            }
        }
    }

    private void StartTimer()
    {
        if (isTimerActive)
        {
            timer -= Time.deltaTime;
        }
    }

    private void StopTimer()
    {
        if (timer <= 0)
        {
            playerRigidbody.gravityScale = gravityScaleAmount;
            isTimerActive = false;
        }
    }

    public void ResetTimer()
    {
        timer = defaultTimer;
    }
}
