using UnityEngine;
using TMPro;

public class Tasklist : MonoBehaviour
{
    public TMP_InputField InputField;
    public TMP_Text TaskText;

    private int taskNumber = 0;

    void Start()
    {
        // ladda sparade uppgifter
        TaskText.text = PlayerPrefs.GetString("SavedTasks", "");
        taskNumber = PlayerPrefs.GetInt("TaskNumber", 0);
    }

    public void AddTask()
    {
        string task = InputField.text;

        if (string.IsNullOrEmpty(task))
            return;

        taskNumber++;

        TaskText.text += taskNumber + ". " + task + "\n";

        // spara uppgifter
        PlayerPrefs.SetString("SavedTasks", TaskText.text);
        PlayerPrefs.SetInt("TaskNumber", taskNumber);
        PlayerPrefs.Save();

        InputField.text = "";
        InputField.ActivateInputField();
    }
         public void ClearTasks() //cleara listan       
    {
        TaskText.text = "";
        taskNumber = 0;

        PlayerPrefs.DeleteKey("SavedTasks");
        PlayerPrefs.DeleteKey("TaskNumber");
    }



}



