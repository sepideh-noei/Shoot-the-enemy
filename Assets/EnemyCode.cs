using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCode : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        BeeCode bee = collision.collider.GetComponent<BeeCode>();
        if (bee != null)
        {
            Destroy(gameObject);
            return;
        }

        EnemyCode enemy = collision.collider.GetComponent<EnemyCode>();
        if(enemy != null)
        {
            return;
        }

        if(collision.contacts[0].normal.y < -0.5)
        {
            Destroy(gameObject);
        }
    }
}
