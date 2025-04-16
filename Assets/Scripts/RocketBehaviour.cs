using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehaviour : MonoBehaviour
{
              
    [SerializeField]
    GameManager gameManager;
    [SerializeField]
    SharkoBehaviour sharkoBehaviour;
    float minX = -9.0f;
    float maxX = 7.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  void  OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sharko"))
        {
            Debug.Log("immune");
            gameManager.amount = 0;
            collision.gameObject.GetComponent<SharkoBehaviour>().TakeDamage(1300);
            //(sharkoBehaviour Oncollision.Meteor)
            sharkoBehaviour.MakeItInvinsible();
            transform.position = new Vector3();
            Random.Range(minX, maxX);          
        }
    }
}
