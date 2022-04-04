using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//From provided tutorial
public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource _effectSource;

    public static SoundManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //Soundeffects from https://mixkit.co/free-sound-effects/cinematic/
    public void PlaySound(AudioClip clip)
    {
        _effectSource.PlayOneShot(clip);
    }

    public void ChangeMasterVolume (float value)
    {
        AudioListener.volume = value;
    }

}
