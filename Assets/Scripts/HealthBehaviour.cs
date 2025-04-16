using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
   
{
    MeteorBehaviour meteorBehaviour;            
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("collided with " + collision.gameObject.name)
            if (collision.gameObject.CompareTag("Sharko"))
        {
            meteorBehaviour.ChangeDirection  (new Vector3 (8, 8, 0));
            collision.gameObject.GetComponent<SharkoBehaviour>().TakeDamage(1300);
          
        }
    }
}
