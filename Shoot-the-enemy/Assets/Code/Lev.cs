using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Lev : MonoBehaviour
{
    Button button = null;
    string tag = "";

    // Start is called before the first frame update
    void Start()
    {
        Global.timeS = 0;
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(() => {  Play(); });
        tag = button.name;
    }
    // Update is called once per frame

    private void Update()
    {
        Global.timeS = 0;
    }

    private void Awake()
    {
        Global.timeS = 0;
        
         

       
    }
    void Play()
    {
        //BgSound.PlayBg();
        Global.timeS = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(Global.Chapter + tag);
        

    }
}
