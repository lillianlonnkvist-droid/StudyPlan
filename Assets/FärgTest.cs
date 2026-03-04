using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class FärgTest : MonoBehaviour
{
    [SerializeField] Color lightTheme;
    [SerializeField] Color darkTheme;

     [SerializeField] AudioMixer mixer;

    [SerializeField] Image thingToChange;
    static bool isDarkTheme = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mixer.SetFloat("Mastersss ", 1);
        if (isDarkTheme)
        {
            thingToChange.color = darkTheme;
        }
        else
        {
            thingToChange.color = lightTheme;
        }
    }

    public void ChangeTheme()
    {
        if (isDarkTheme)
        {
            isDarkTheme = false;
            thingToChange.color = lightTheme;
        }
        else {
            isDarkTheme = true;
            thingToChange.color = darkTheme;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
