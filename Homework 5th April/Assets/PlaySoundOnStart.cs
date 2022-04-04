using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Modified from provided tutorial
public class PlaySoundOnStart : MonoBehaviour
{

    [SerializeField] private AudioClip _clip;

    public Button button;

    void Start()
    {
        button.onClick.AddListener(OnClick);

    }

    public void OnClick()
    {
        SoundManager.instance.PlaySound(_clip);
    }
}
