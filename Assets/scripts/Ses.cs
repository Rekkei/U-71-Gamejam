using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ses : MonoBehaviour
{
    [SerializeField] Slider volume;
    public bool musicOn = true;
    public GameObject checkOn;
    public GameObject checkOff;


    void Start()
    {
        volume.value = PlayerPrefs.GetFloat("musicv");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("musicv", volume.value);
    }

    public void VolumeChanger()
    {
        AudioListener.volume = volume.value;
    }

    public void MusicOff()
    {
        if (musicOn) 
        {
            musicOn = false;
            checkOff.SetActive(true);
            checkOn.SetActive(false);
        }     
    }

    public void MusicOn()
    {
        if (musicOn == false) 
        {
            musicOn = true;
            checkOn.SetActive(true);
            checkOff.SetActive(false);
        }   
    }

}
