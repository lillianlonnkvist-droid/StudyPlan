using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timeText;

    private float timeSeconds = 0f;
    private bool isRunning = false;

    void Start()
    {
        // ladda sparad tid
        timeSeconds = PlayerPrefs.GetFloat("SavedTime", 0f);
        UpdateText();
    }

    void Update()
    {
        if (!isRunning) return;

        if (timeSeconds > 0)
        {
            timeSeconds -= Time.deltaTime;
            UpdateText();
        }
        else
        {
            timeSeconds = 0;
            isRunning = false;
            UpdateText();
            Debug.Log("Time finished!");
        }
    }

    public void Add10Minutes()
    {
        timeSeconds += 600f;
        SaveTime();
        UpdateText();
    }

    public void Minus10Minutes()
    {
        Debug.Log("Minus button pressed");

        timeSeconds -= 600f;

        if (timeSeconds < 0)
            timeSeconds = 0;

        UpdateText();
    }

    public void StartTimer()
    {
        if (timeSeconds > 0)
            isRunning = true;
    }

    void UpdateText()
    {
        int minutes = Mathf.FloorToInt(timeSeconds / 60);
        int seconds = Mathf.FloorToInt(timeSeconds % 60);

        timeText.text = $"{minutes:00}:{seconds:00}";
    }

    void SaveTime()
    {
        PlayerPrefs.SetFloat("SavedTime", timeSeconds);
        PlayerPrefs.Save();
    }

    void OnApplicationQuit()
    {
        SaveTime();
    }
}