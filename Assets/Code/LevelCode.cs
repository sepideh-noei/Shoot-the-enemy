using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCode : MonoBehaviour
{
    //private static int nextLevelId = 1;
    public string chapSet;
    public int idSet;
    private EnemyCode[] enemies;
    private float time;
    int checkSound = 1;
    public GameObject PauseMenueCanvas;
    public GameObject StarMenueCanvas;
    public static int EnC;
    private void Start()
    {
        
        GameObject.FindGameObjectWithTag("MusicMenu").GetComponent<BgMenuMusic>().StopMusic();
        GameObject.FindGameObjectWithTag("Music").GetComponent<BgSound>().PlayMusic();
      


    }
    private void OnEnable()
    {
        
        enemies = FindObjectsOfType<EnemyCode>();
        

    }

    void Update()
    {
        
        if (Global.timeS==0)
        {
            Time.timeScale = 1f;

        }
        
        foreach (EnemyCode enemy in enemies)
        {
            if (enemy != null)
            {
                return;
            }
        }
        time += Time.deltaTime;
        Debug.Log("you kill enemies");
        if(checkSound==1)
        Sound.PlaySound("LevelComplete");
      checkSound = 0;
        
        if(time>=1)
       {
            //nextLevelId++;
            
          //string nextLevel = Global.Chapter+"level" + nextLevelId;
            TotalPointCode.totalPoints += ScoreCode.scoreValue;
            //ScoreCode.scoreValue = 0;
            idSet++;
            if ((chapSet == "night" && idSet > 2) || (chapSet == "morning" && idSet > 5) || (chapSet == "evening" && idSet > 2))
            {
                Time.timeScale = 0f;
                Global.timeS = 1;
                //SceneManager.LoadScene("Menu");
                MainMenuCode.ActiveStep();
                GameObject.FindGameObjectWithTag("Music").GetComponent<BgSound>().StopMusic();
               

            }

            else
            {
               
                Time.timeScale = 0f;
                StarMenueCanvas.SetActive(true);
                Global.timeS = 1;
                //SceneManager.LoadScene(chapSet + "level" + idSet);

            }

        }
    }
}
