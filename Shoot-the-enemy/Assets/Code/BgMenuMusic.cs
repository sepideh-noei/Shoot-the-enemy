using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BgMenuMusic : MonoBehaviour
{
    private AudioSource _audioSource2;
    public static AudioClip bgSong2;

    private void Start()
    {
        
    }
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource2 = GetComponent<AudioSource>();
        BgMenuMusic.bgSong2 = Resources.Load<AudioClip>("BgMenuMusic");
        _audioSource2.clip = bgSong2;
        _audioSource2.loop = true;
        
    }
    private void Update()
    {
        _audioSource2.volume = Always.vol ;
        if (!Always.musicmuted)
        {

            _audioSource2.volume = 0;
        }
       

    }
    public void PlayMusic()
    {
        if (_audioSource2.isPlaying) return;
        
        _audioSource2.PlayOneShot(bgSong2);
    }

    public void StopMusic()
    {
        _audioSource2.Stop();
    }
}
