using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BeeCode : MonoBehaviour
{
    [SerializeField] private float throwPower = 500;
    private Vector3 primaryPosition;
    private bool beeThrow;
    private float time;

      private void Awake()
   {
       primaryPosition = transform.position;
   }

     private void Update()
     {
         GetComponent<LineRenderer>().SetPosition(0 , transform.position);
         GetComponent<LineRenderer>().SetPosition(1 , primaryPosition); 

        if (beeThrow && GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1)
         {
             time += Time.deltaTime;
         }

         if(transform.position.y > 30 || transform.position.y < -30 ||
            transform.position.x > 30 || transform.position.x < -30 ||
            time > 1.8)
         {
             string presentSceneName = SceneManager.GetActiveScene().name;
             SceneManager.LoadScene(presentSceneName);
         }
     }

     private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;
        GetComponent<LineRenderer>().enabled = true;
    }

    private void OnMouseUp()
    {
      GetComponent<SpriteRenderer>().color = Color.white;

      Vector2 directionToPrimaryPosition = primaryPosition - transform.position;
      GetComponent<Rigidbody2D>().AddForce(directionToPrimaryPosition * throwPower);
      GetComponent<Rigidbody2D>().gravityScale = 1;
      beeThrow = true;

      GetComponent<LineRenderer>().enabled = false;
    }
     
     private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(newPosition.x<= -4.3&& newPosition.y>=0.37)
        transform.position = new Vector3( newPosition.x , newPosition.y);
    }
}
