using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StarsAndScore : MonoBehaviour
{
    public GameObject StarLeft;
    public GameObject StarRight;
    public GameObject StarMiddle;
    public GameObject NextButton;
    float EnemyCount = 0.00f;
    float score=0.00f;
    
    // Start is called before the first frame update
    void Start()
    {
        EnemyCount = LevelCode.EnC;
        score = Global.scoreGlobal;
    }
    private void Awake()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Global.timeS = 1;
        Time.timeScale = 0f;
        //Global.LevelReset = 1;
        score = Global.scoreGlobal;
        EnemyCount = LevelCode.EnC;
        Debug.Log(Global.scoreGlobal);
        Debug.Log(EnemyCount);
        Debug.Log(score );
        if (score == 0)
        {
            StarLeft.SetActive(false);
            StarMiddle.SetActive(false);
            StarRight.SetActive(false);
        }
        else if ((score ) <= ((EnemyCount * 100f) * (1f / 3f)))
        {
            StarLeft.SetActive(true);
            StarMiddle.SetActive(false);
            StarRight.SetActive(false);
            Debug.Log(score );
            Debug.Log((EnemyCount * 100f) * (1f / 3f));
        }
        else if (((score ) <= ((EnemyCount * 100f) * (2f / 3f))) && ((score ) > ((EnemyCount * 100f) * (1f / 3f))))
        {
            StarLeft.SetActive(true);
            StarMiddle.SetActive(true);
            StarRight.SetActive(false);
            Debug.Log(score);
            Debug.Log((EnemyCount * 100f) * (1f / 3f));

        }
        else if (((score) <= ((EnemyCount * 100f) * (3f / 3f))) && ((score ) > ((EnemyCount * 100f) * (2f / 3f))))
        {
            StarLeft.SetActive(true);
            StarMiddle.SetActive(true);
            StarRight.SetActive(false);
            Debug.Log(score );
            Debug.Log((EnemyCount * 100f) * (2f / 3f));
        }

         if(score == (EnemyCount * 100f))
        {
            if(Global.LevId!=10)
                NextButton.SetActive(true);

            StarLeft.SetActive(true);
            StarMiddle.SetActive(true);
            StarRight.SetActive(true);
        }

    }
}
