using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuCode : MonoBehaviour
{
    
    public  GameObject stepMenu;
    public  GameObject submenu;
    public  GameObject mainmenu;
    public  GameObject optionmenu;
    public static int KillSound = 0;
    public static int stepon = 0;

    private void Start()
    {
       
    }

    private void Update()
    {
        GameObject.FindGameObjectWithTag("MusicMenu").GetComponent<BgMenuMusic>().PlayMusic();
    }
    void Awake()
    {
        
       
        if (stepon == 1)
        {
            stepMenu.SetActive(true);
            submenu.SetActive(false);
            mainmenu.SetActive(false);
            optionmenu.SetActive(false);
            
        }
    }

    public static void ActiveStep()
    {
        stepon = 1;
    }

}
public class Global
{
    
    public static string Chapter = "";
    public static bool back = false;
    
   
}






