using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalPointCode : MonoBehaviour
{
    public static int totalPoints;
    public bool[] MorningLev;
    Text total;
    
    void Start()
    {
      
        total = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        total.text = "total: " + totalPoints;
    }
}
