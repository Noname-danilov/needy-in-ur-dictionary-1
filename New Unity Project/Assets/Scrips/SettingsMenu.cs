﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = !Screen.fullScreen;//isFullscreen;
        Debug.Log(Screen.fullScreen);
    }
}
