using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public static AudioClip shotBeeSound, drawBeeSound, enemyDeathSound, levelCompleteSound, cratesFall, clickon;
    static AudioSource MyAudio;

    // Start is called before the first frame update
    void Start()
    {
        shotBeeSound = Resources.Load<AudioClip>("shotBee");
        drawBeeSound = Resources.Load<AudioClip>("drawBee");
        MyAudio = GetComponent<AudioSource>();
        

    }

    // Update is called once per frame
    void Update()
    {

        MyAudio.volume = Always.vol - 0.2f;
        if (!Always.sfxmuted)
        {
            MyAudio.volume = 0;
        }
    }
    public static void Muteit()
    {

    }
    public static void PlaySound(string clip)
    {

        switch (clip)
        {
            case "shotBee":
                {
                    MyAudio.PlayOneShot(shotBeeSound);
                    break;
                }
            case "drawBee":
                {

                    MyAudio.PlayOneShot(drawBeeSound);

                    break;
                }
            case "enemyDeath":
                {
                    int i = Random.Range(1, 3);
                    enemyDeathSound = Resources.Load<AudioClip>("EnemyDied" + i);
                    MyAudio.PlayOneShot(enemyDeathSound);
                    break;
                }
            case "LevelComplete":
                {
                    int i = Random.Range(1, 3);
                    levelCompleteSound = Resources.Load<AudioClip>("LevelFinish" + i);

                    MyAudio.PlayOneShot(levelCompleteSound);
                    break;
                }

            case "cratesFall":
                {
                    int i = Random.Range(1, 5);
                    cratesFall = Resources.Load<AudioClip>("cratesFall" + i);

                    MyAudio.PlayOneShot(cratesFall);
                    break;
                }



        }
    }
    public static void playclick()
    {
      
        

    }
}
      
    
