using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSound : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        CrateSound crate = collision.collider.GetComponent<CrateSound>();
        if (crate != null)
        {
            Sound.PlaySound("cratesFall");
            
        }
    }

}