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
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(() => {  Play(); });
        tag = button.name;
    }
    // Update is called once per frame
    


    void Play()
    {
        //BgSound.PlayBg();
        Global.timeS = 0;
        SceneManager.LoadScene(Global.Chapter + tag);
        

    }
}
