using TMPro;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public GameObject infoPanel;

    [SerializeField, TextArea] string Info;

    public void ShowPanel()
    {
        infoPanel.SetActive(true);
        infoPanel.GetComponentInChildren<TMP_Text>().text = Info;
    }

    public void HidePanel()
    {
        infoPanel.SetActive(false);
    }
}


