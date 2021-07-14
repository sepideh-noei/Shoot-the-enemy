using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCode : MonoBehaviour
{
    [SerializeField] private GameObject cloudParticle;
    [SerializeField] private GameObject scoreParticle;

    public void Start()
    {
        //LevelCode.EnC = GameObject.FindGameObjectsWithTag("En").Length;
    }

    public void Awake()
    {
        //LevelCode.EnC = GameObject.FindGameObjectsWithTag("En").Length;
    }
    public void Update()
    {
        //if(Global.LevelReset==0)
        //LevelCode.EnC = GameObject.FindGameObjectsWithTag("En").Length;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BeeCode bee = collision.collider.GetComponent<BeeCode>();
        if (bee != null)
        {
            ScoreCode.scoreValue += 100f;
            Global.scoreGlobal = ScoreCode.scoreValue;
            TotalPointCode.totalPoints += 100;
            Instantiate(cloudParticle, transform.position, Quaternion.identity);
            Instantiate(scoreParticle, transform.position, Quaternion.identity);
             Sound.PlaySound("enemyDeath");
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
            ScoreCode.scoreValue += 100f;
            Global.scoreGlobal = ScoreCode.scoreValue;
            TotalPointCode.totalPoints += 100;
            Instantiate(cloudParticle, transform.position, Quaternion.identity);
            Instantiate(scoreParticle, transform.position, Quaternion.identity);
            Sound.PlaySound("enemyDeath");
            Destroy(gameObject);
        }
    }
}
