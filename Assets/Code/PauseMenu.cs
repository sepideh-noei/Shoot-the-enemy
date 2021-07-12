using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    


    // Update is called once per frame
    void Update()
    {
        

         if (pauseMenuUI != null)
        {
            if(GameIsPaused)
            {
                
                Time.timeScale = 0f;
            }
            else
            {
                
                Time.timeScale = 1f;
            }
        }
        
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        
        GameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Global.timeS = 1;
    }
    public void Replay()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        GameIsPaused = false;
        SceneManager.LoadScene(currentScene.name);
        Global.timeS = 1;
        ScoreCode.scoreValue = 0;
    }
    public void loadMenu()
    {


    }

}
