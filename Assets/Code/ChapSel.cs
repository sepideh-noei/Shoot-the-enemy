using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChapSel : MonoBehaviour
{
    Button button = null;
    string Tag = null;

    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(() => { Click();});
        Tag = transform.tag;
    }

    // Update is called once per frame
    void Update()
    {
        
            
        
    }
    void Click()
    {
        switch (Tag)
        {
            case "morningchap":
                Global.Chapter = "morning";
                break;
            case "eveningchap":
                Global.Chapter = "evening";
                break;
            case "nightchap":
                Global.Chapter = "night";
                break;
        }
    }

    //void Play()
    //{
     //   SceneManager.LoadScene(Global.Chapter+"level1");
    //}
}

     
    
        
    

