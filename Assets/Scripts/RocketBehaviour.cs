//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
public class RocketBehaviour : MonoBehaviour
{             
    GameManager gameManager;
    float minX = -9.0f;
    float maxX = 7.0f;
    private void Start()
    {
      
      gameManager = GameManager.gameManager;    
    }


    /*
    void  OnCollisionEnter2D(Collision2D collision)
     {
         if (collision.gameObject.CompareTag("Sharko"))
         {
             Debug.Log("immune");
             gameManager.amount = 0;
             //(sharkoBehaviour Oncollision.Meteor)
             sharkoBehaviour.MakeItInvinsible();
             transform.position = new Vector3();
             Random.Range(minX, maxX);          
         }
     } */
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sharko"))
        {
            gameManager.SetAmount(0);
            //(sharkoBehaviour Oncollision.Meteor)
           other.GetComponent<SharkoBehaviour>().MakeItInvinsible();
            transform.position = new Vector3();
         
            Random.Range(minX, maxX);
        }
    }
}