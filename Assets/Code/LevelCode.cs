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
            ScoreCode.scoreValue = 0;
            idSet++;
            if ((chapSet == "night" && idSet > 2) || (chapSet == "morning" && idSet > 5) || (chapSet == "evening" && idSet > 2))
            {
                
                SceneManager.LoadScene("Menu");
                MainMenuCode.ActiveStep();
                GameObject.FindGameObjectWithTag("Music").GetComponent<BgSound>().StopMusic();
               

            }

            else
            {
                
                SceneManager.LoadScene(chapSet + "level" + idSet);
                
            }

        }
    }
}
