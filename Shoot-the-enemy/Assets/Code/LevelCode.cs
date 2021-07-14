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
    public static string nextlevelAddress;

    private void Start()
    {

        GameObject.FindGameObjectWithTag("MusicMenu").GetComponent<BgMenuMusic>().StopMusic();
        GameObject.FindGameObjectWithTag("Music").GetComponent<BgSound>().PlayMusic();
        if (Global.timeS == 0)
        {
            Time.timeScale = 1f;

        }



    }
    private void OnEnable()
    {
       
            Time.timeScale = 1f;

       
        enemies = FindObjectsOfType<EnemyCode>();


    }
    private void Awake()
    {
        if (Global.timeS == 0)
        {
            Time.timeScale = 1f;

        }
        LevelCode.EnC = GameObject.FindGameObjectsWithTag("En").Length;
    }

    void Update()
    {
        



            

        



        nextlevelAddress = chapSet;


        if (Global.timeS == 0)
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
        if (checkSound == 1)
            Sound.PlaySound("LevelComplete");
        checkSound = 0;

        if (time >= 1)
        {
            //nextLevelId++;

            //string nextLevel = Global.Chapter+"level" + nextLevelId;

            
            //ScoreCode.scoreValue = 0;

            Global.LevId = idSet;
            if ((chapSet == "night" && idSet == 15) || (chapSet == "morning" && idSet ==15) || (chapSet == "evening" && idSet == 15))
            {
                Time.timeScale = 0f;
                Global.timeS = 1;
                SceneManager.LoadScene("Menu");
                MainMenuCode.ActiveStep();
                GameObject.FindGameObjectWithTag("Music").GetComponent<BgSound>().StopMusic();


            }


            else
            {

                Global.LevId = idSet;
                Time.timeScale = 0f;
               
                StarMenueCanvas.SetActive(true);
                Global.timeS = 1;
                //SceneManager.LoadScene(chapSet + "level" + idSet);

            }

        }
    }
}
    
        

