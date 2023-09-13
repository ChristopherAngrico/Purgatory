using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    private string volumeValue = "VolumeValue";
    [SerializeField] private Slider volumeSlider = null;
    private void OnEnable()
    {
        LoadValues();
    }
    public void SaveVolumeButton(){
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat(this.volumeValue, volumeValue);
        LoadValues();
    }
    private void LoadValues(){
        float volumeValue = PlayerPrefs.GetFloat(this.volumeValue);
        volumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
