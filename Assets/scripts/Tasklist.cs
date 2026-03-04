using UnityEngine;
using TMPro;

public class TaskList : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text tasksText;

    int count = 0;

    public void AddTask()
    {
        if (inputField.text.Trim() == "") return;

        count++;
        tasksText.text += count + ". " + inputField.text + "\n";

        inputField.text = "";
    }
}