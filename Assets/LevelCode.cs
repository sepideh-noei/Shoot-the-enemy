using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCode : MonoBehaviour
{
    private static int nextLevelId = 1;
    private EnemyCode[] enemies;

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
        Debug.Log("you kill enemies");

        nextLevelId++;
        string nextLevel = "level" + nextLevelId;
        SceneManager.LoadScene(nextLevel);
    }
}
