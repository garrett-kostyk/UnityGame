using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine.PostFX;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    public float volume;
    public Slider volumeSlider;

    
    public void SaveToJSON()
    {   
        volume = volumeSlider.value;
        string volumeLevel = JsonUtility.ToJson(volume);
        String filePath = Application.persistentDataPath + "/volume.json";
        System.IO.File.WriteAllText(filePath, volumeLevel);
    }
}
