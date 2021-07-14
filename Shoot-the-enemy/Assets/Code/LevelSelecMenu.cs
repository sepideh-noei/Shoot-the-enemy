using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelecMenu : MonoBehaviour
{
    public int totalLevel;
    public int unlockedLevel = 1;
    private LevelButton[] levelButton;
    private int totalPage = 0;
    private int page = 0;
    private int pageItem = 15;
    public GameObject nextButton;
    public GameObject backButton;

    void OnEnable()
    {
        levelButton = GetComponentsInChildren<LevelButton>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Refresh();
    }

    public void StartLevel(int level)
    {
        if (level == unlockedLevel)
        {
            unlockedLevel += 1;
            Refresh();
        }
    }

    public void ClickNext()
    {
        page += 1;
        Refresh();
    }
    public void ClickBack()
    {
        page -= 1;
        Refresh();
    }
    public void Refresh()
    {
        totalPage = totalLevel / pageItem;
        int index = page * pageItem;

        for (int i = 0; i < levelButton.Length; i++)
        {
            int level = index + i + 1;

            if (level <= totalLevel)
            {
                levelButton[i].gameObject.SetActive(true);
                levelButton[i].Setup(level, level <= unlockedLevel);
            }
            else
            {
                levelButton[i].gameObject.SetActive(false);
            }
        }
        CheckButton();
    }
    private void CheckButton()
    {
        backButton.SetActive(page > 0);
        nextButton.SetActive(page < totalPage);
    }
}
