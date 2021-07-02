using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changecam : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject vCam;
    public GameObject theGame;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
        {
            theGame.SetActive(false);
            mainCam.SetActive(false);
            vCam.SetActive(true);

        }
        else if(Input.deviceOrientation == DeviceOrientation.LandscapeLeft|| Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            theGame.SetActive(true);
            mainCam.SetActive(true);
            vCam.SetActive(false);

        }
    }
}
