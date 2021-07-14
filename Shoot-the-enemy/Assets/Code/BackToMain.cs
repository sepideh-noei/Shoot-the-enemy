﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BackToMain : MonoBehaviour
{
    Button button = null;


    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(() => { Click(); });
        tag = transform.tag;
    }


    void Update()
    {

        

    }
    public void Click()
    {
        PauseMenu.GameIsPaused = false;
        Global.back = true;
        Global.timeS = 0;
        SceneManager.LoadScene("Menu");
        GameObject.FindGameObjectWithTag("Music").GetComponent<BgSound>().StopMusic();
    }
}