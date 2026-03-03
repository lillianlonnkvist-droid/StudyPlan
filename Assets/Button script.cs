using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowInfo : MonoBehaviour
{
    public GameObject Background2;

    [SerializeField, TextArea] string Info;

    public void ShowPanel()
    {
        Background2.SetActive(true);
        Background2.GetComponentInChildren<TMP_Text>().text = Info;
    }

    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void HidePanel()
    {
        Background2.SetActive(false);
    }
}


