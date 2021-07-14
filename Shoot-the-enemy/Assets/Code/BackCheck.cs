using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCheck : MonoBehaviour
{
    public GameObject Menu;
    public GameObject SubMenu;
    // Start is called before the first frame update
    void Start()
    {
        if(Global.back)
        {
            Menu.SetActive(false);
            SubMenu.SetActive(true);
            Global.back = false;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
