//clean code completed
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
public class RocketBehaviour : MonoBehaviour
{             
    GameManager gameManager;
    float minX = -9.0f;
    float maxX = 7.0f;
    float minY = -8.0f;
    float maxY = 7.0f;
    private void Start()
    { 
      gameManager = GameManager.gameManager;    
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(EnumManager.Tags.Sharko.ToString()))
        {
            gameManager.SetAmount(0);
            //(sharkoBehaviour Oncollision.Meteor)
           other.GetComponent<SharkoBehaviour>().MakeItInvinsible();
           transform.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
        }
    }
}