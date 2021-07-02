using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 public class OptionStatic : MonoBehaviour
{
     bool sfxmuted = true;
    bool musicmuted = true;
    // Start is called before the first frame update


    void Start()
    {
        if (Always.sfxmuted == false)
        {
            GameObject.Find("SoundEffectsToggle").GetComponent<Toggle>().isOn = false;
        }
        else if (Always.sfxmuted == true)
        {
            GameObject.Find("SoundEffectsToggle").GetComponent<Toggle>().isOn = true;
        }

        if (Always.musicmuted == false)
        {
            GameObject.Find("MusicToggle").GetComponent<Toggle>().isOn = false;
        }
        else if (Always.musicmuted == true)
        {
            GameObject.Find("MusicToggle").GetComponent<Toggle>().isOn = true;
        }

        GameObject.Find("MusicSlider").GetComponent<Slider>().value = Always.vol;
    }

    private  void Awake()
    {
     
    }
    // Update is called once per frame
     void Update()
    {

       

    }
    public  void Muteditsfx()
    {
        sfxmuted = !sfxmuted;
        Always.sfxmuted = sfxmuted;
    }
    public void Muteditmusic()
    {
        musicmuted = !musicmuted;
        Always.musicmuted = musicmuted;
    }

    public void VolChange()
    {
        Always.vol= GameObject.Find("MusicSlider").GetComponent<Slider>().value;
        Debug.Log(Always.vol.ToString());
    }
}
