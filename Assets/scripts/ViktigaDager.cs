using TMPro;
using UnityEngine;

public class ImportantDays : MonoBehaviour
{
    public TMP_InputField dayInput;
    public TMP_InputField descriptionInput;
    public TextMeshProUGUI outputText;


    void Start()
    {
        outputText.text = PlayerPrefs.GetString("ImportantDays", "");
    }
    public void AddDay()
    {
        string day = dayInput.text;
        string description = descriptionInput.text;

        outputText.text += day + " - " + description + "\n";

        PlayerPrefs.SetString("ImportantDays", outputText.text);
        PlayerPrefs.Save();
        dayInput.text = "";
        descriptionInput.text = "";
    }
    public void ClearDays()
    {
        outputText.text = "";
        PlayerPrefs.DeleteKey("ImportantDays");
    }
}