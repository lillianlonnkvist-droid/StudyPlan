using UnityEngine;
using TMPro;

public class Tasklist : MonoBehaviour
{


    public TMP_InputField InputField;
    public TMP_Text TaskText;

    private int taskNumber = 0;

    public void AddTask()
    {
        string task = InputField.text;
        if (!string.IsNullOrEmpty(task))
        return;
        
        taskNumber++;
        TaskText.text += taskNumber + ". " + task + "\n";
        InputField.text = "";
        InputField.ActivateInputField();
    }
}