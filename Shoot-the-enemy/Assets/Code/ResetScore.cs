using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        ScoreCode.scoreValue = 0;
        Global.scoreGlobal = 0;
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
