//FILE: AudioManager.cs
//PROJECT: Will Of The Woods
//PROGRAMMER: John Gotts
//FIRST VERSION: 19/12/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

//NAME: AudioManager
//PURPOSE: this class is used to manage all the audio aspects volume levels for the game
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioMixer mixer;
    public AudioSettings[] settings;

    //an enum for the specific groups within the audio mixer
    private enum AudioGroups
    {
        Music,
        SFX,
        Ambient
    }

    private void Awake()
    {
        instance = GetComponent<AudioManager>();
    }

    private void Start()
    {
        for (int i = 0; i < settings.Length; i++)
        {
            settings[i].Initialize();
        }
    }

    //Function: SetMusicVolume
    //DESCRIPTION: this function sets the musics volume
    //PARAMETERS: float value
    //RETURNS: None
    public void SetMusicVolume(float value)
    {
        settings[(int)AudioGroups.Music].SetExposedParam(value);
    }

    //Function: SetSFXVolume
    //DESCRIPTION: this function sets the sfx volume
    //PARAMETERS: float value
    //RETURNS: None
    public void SetSFXVolume(float value)
    {
        settings[(int)AudioGroups.SFX].SetExposedParam(value);
    }

    //Function: SetAmbientVolume
    //DESCRIPTION: this function sets the ambient volume
    //PARAMETERS: float value
    //RETURNS: None
    public void SetAmbientVolume(float value)
    {
        settings[(int)AudioGroups.Ambient].SetExposedParam(value);
    }
}

//NAME: AudioSettings
//PURPOSE: This class is used to set the exposed parameters from the audio mixer
[System.Serializable]
public class AudioSettings
{
    public string exposedParam;
    public Slider slider;

    //Function: Initialize
    //DESCRIPTION: this function is used to get the exposed parameters float and is used on start for the saving of the values
    //PARAMETERS: None
    //RETURNS: None
    public void Initialize()
    {
        slider.value = PlayerPrefs.GetFloat(exposedParam);
    }

    //Function: SetExposedParam
    //DESCRIPTION: this function is used to set the float for 
    //PARAMETERS:
    //RETURNS:
    public void SetExposedParam(float value)
    {
        AudioManager.instance.mixer.SetFloat(exposedParam, value);
        PlayerPrefs.SetFloat(exposedParam, value);
    }
}
