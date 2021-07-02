using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Always : MonoBehaviour
{
    public static bool sfxmuted = true;
    public static bool musicmuted = true;
    public static float vol = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        

    }

    public static void  pli()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        
    }
}
