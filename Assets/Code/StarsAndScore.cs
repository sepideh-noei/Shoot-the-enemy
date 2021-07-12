using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsAndScore : MonoBehaviour
{
    public GameObject StarLeft;
    public GameObject StarRight;
    public GameObject StarMiddle;
    public GameObject NextButton;
    int EnemyCount;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        EnemyCount = LevelCode.EnC;
        score = Global.scoreGlobal;
    }

    // Update is called once per frame
    void Update()
    {
        score = Global.scoreGlobal;
        EnemyCount = LevelCode.EnC;
        Debug.Log(Global.scoreGlobal);
        if (score == 0)
        {
            StarLeft.SetActive(false);
            StarMiddle.SetActive(false);
            StarRight.SetActive(false);
        }
        else if ((score / EnemyCount) <= ((EnemyCount * 100) * (1 / 3)))
        {
            StarLeft.SetActive(true);
            StarMiddle.SetActive(false);
            StarRight.SetActive(false);
        }
        else if (((score / EnemyCount) <= ((EnemyCount * 100) * (2 / 3))) && ((score / EnemyCount) > ((EnemyCount * 100) * (1 / 3))))
        {
            StarLeft.SetActive(true);
            StarMiddle.SetActive(true);
            StarRight.SetActive(false);
        }
        else if (((score / EnemyCount) <= ((EnemyCount * 100) * (3 / 3))) && ((score / EnemyCount) > ((EnemyCount * 100) * (2 / 3))))
        {
            StarLeft.SetActive(true);
            StarMiddle.SetActive(true);
            StarRight.SetActive(true);
        }

         if(score == (EnemyCount * 100))
        {
            NextButton.SetActive(true);
        }

    }
}
