using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnClick : MonoBehaviour
{
    static AudioSource MyAudio;
    public static AudioClip clickon;
    
    public void Start()
    {
        MyAudio = GetComponent<AudioSource>();
        int i = Random.Range(1, 3);
        clickon = Resources.Load<AudioClip>("Click" + i);
        MyAudio.PlayOneShot(clickon);

    }

    
}
