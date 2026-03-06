using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    public TMP_Text timeText;

    private float timeSeconds;
    private bool isRunning = false;

    private DateTime endTime;

    void Start()
    {
        if (PlayerPrefs.HasKey("EndTime"))
        {
            string savedTime = PlayerPrefs.GetString("EndTime");
            endTime = DateTime.Parse(savedTime);

            float remaining = (float)(endTime - DateTime.Now).TotalSeconds;

            if (remaining > 0)
            {
                timeSeconds = remaining;
                isRunning = true;
            }
            else
            {
                timeSeconds = 0;
            }

            UpdateText();
        }
    }

    void Update()
    {
        if (!isRunning) return;

        timeSeconds -= Time.deltaTime;

        if (timeSeconds <= 0)
        {
            timeSeconds = 0;
            isRunning = false;
        }

        UpdateText();
    }

    public void Add10Minutes()
    {
        timeSeconds += 600;
        UpdateText();
    }

    public void Minus10Minutes()
    {
        timeSeconds -= 600;

        if (timeSeconds < 0)
            timeSeconds = 0;

        UpdateText();
    }

    public void StartTimer()
    {
        if (timeSeconds > 0)
        {
            endTime = DateTime.Now.AddSeconds(timeSeconds);
            PlayerPrefs.SetString("EndTime", endTime.ToString());
            PlayerPrefs.Save();

            isRunning = true;
        }
    }

    void UpdateText()
    {
        int minutes = Mathf.FloorToInt(timeSeconds / 60);
        int seconds = Mathf.FloorToInt(timeSeconds % 60);

        timeText.text = $"{minutes:00}:{seconds:00}";
    }
}