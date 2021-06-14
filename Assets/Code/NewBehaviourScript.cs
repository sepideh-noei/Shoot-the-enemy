using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Awake()
    {
        
        StartCoroutine(RotateMe(Vector3.back * 90, 0.8f));
    }

    IEnumerator RotateMe(Vector3 byAngles, float inTime)
    {
        var fromAngle = transform.rotation;
        var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
        for(int i=0;i<=5;i++)
        {
            for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
            {
                transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
                yield return null;
            }
        }

    }
}
