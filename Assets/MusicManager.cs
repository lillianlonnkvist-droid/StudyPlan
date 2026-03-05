using UnityEngine;
using UnityEngine.Audio;

public class MusicVolumeController : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioMixer musicMixerGroup;
    public float volumeStep = 0.1f;
    static float volume = 1;

    public void IncreaseVolume()
    {
        volume += volumeStep;
        musicMixerGroup.SetFloat("Volume", volume);
        //musicSource.volume = Mathf.Clamp01(musicSource.volume + volumeStep);
    }

    public void DecreaseVolume()
    {
        volume -= volumeStep;
        musicMixerGroup.SetFloat("Volume", volume);
        //musicSource.volume = Mathf.Clamp01(musicSource.volume - volumeStep);
    }
}