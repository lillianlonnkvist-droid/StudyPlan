using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneApp(string StudieApp)
    {
        SceneManager.LoadScene("StudieApp");
    }
    public void LoadSceneSettings(string Settings)
    {
        SceneManager.LoadScene("Settings");
    }
    public void LoadSceneHome(string HomeScreen)
    {
        SceneManager.LoadScene("HomeScreen");
    }



    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

}

