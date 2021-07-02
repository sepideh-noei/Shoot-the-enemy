using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgSound : MonoBehaviour
{
    private AudioSource _audioSource;
    public static AudioClip bgSong;

    private void Start()
    {

    }
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
        BgSound.bgSong = Resources.Load<AudioClip>("bgMusic");
        _audioSource.clip = bgSong;
        _audioSource.loop = true;
        
      
    }

    private void Update()
    {
        _audioSource.volume = Always.vol + 0.05f;
        if (!Always.musicmuted)
        {
            _audioSource.volume = 0;
        }

    
    }
    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.clip = bgSong;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }

}
