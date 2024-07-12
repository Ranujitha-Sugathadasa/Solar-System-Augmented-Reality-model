using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool muted = false;
    private bool backgroundMusicMuted = false; // Optional flag for background music

    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
        // Mute based on initial muted state
        AudioListener.pause = muted;
    }

    public void OnSceneLoad() // Called before scene loading (customizable)
    {
        // Stop Audio Sources from previous scene (assuming they're children)
        foreach (Transform child in transform)
        {
            AudioSource childAudioSource = child.GetComponent<AudioSource>();
            if (childAudioSource != null)
            {
                childAudioSource.Stop();
            }
        }
    }

    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            // Mute all Audio Sources (or adjust based on backgroundMusicMuted)
            AudioListener.pause = muted;
        }
        else
        {
            muted = false;
            AudioListener.pause = muted;
        }
        save();
        UpdateButtonIcon();
    }

    public void ToggleBackgroundMusicMute() // Optional function for background music
    {
        backgroundMusicMuted = !backgroundMusicMuted; // Toggle flag
        // Mute specific Audio Sources for background music based on flag
        // (implementation depends on your setup)
    }

    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        }
        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
