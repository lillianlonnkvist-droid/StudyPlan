using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;




public class FärgTest : MonoBehaviour
{
    [SerializeField] Color lightTheme;
    [SerializeField] Color darkTheme;


    [SerializeField] Image[] themedUI;
    static bool isDarkTheme = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (isDarkTheme)
        {
            for (int i = 0; i < themedUI.Length; i++)
            {
                themedUI[i].color = darkTheme;
            }
        }
        else
        {
            for (int i = 0; i < themedUI.Length; i++)
            {
                themedUI[i].color = lightTheme;
            }
        }
    }

    public void ChangeTheme()
    {
        if (isDarkTheme)
        {
            isDarkTheme = false;
            for (int i = 0; i < themedUI.Length; i++)
            {
                themedUI[i].color = lightTheme;
            }
        }
        else {
            isDarkTheme = true;
            for (int i = 0; i < themedUI.Length; i++)
            {
                themedUI[i].color = darkTheme;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
