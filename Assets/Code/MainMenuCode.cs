﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCode : MonoBehaviour
{
   
    public void ExitGame ()
    {
        Debug.Log(".Exit!");
        Application.Quit();
    }
}
