using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class MeteorBehaviour : MonoBehaviour
{
    [SerializeField]
    internal SharkoBehaviour sharkoBehaviour;
    private Vector3 direction;
    EnemiesController enemiesController;
    [SerializeField]
     Count count;
    
    // Start is called before the first frame update
     void Start()
    {
        ChangeDirection(new Vector3(2, -2, 0));
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    internal void ChangeDirection(Vector3 _newDirection)
    {
        direction = _newDirection;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("collided with " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Sharko"))
            {
            if ( sharkoBehaviour.immune == true)
            {
                sharkoBehaviour.TakeDamage(0) ;
                Destroy(gameObject);
                Debug.Log("qwertyuiopasdfghjklzxcvbnm");
                enemiesController.Meteor[1].SetActive(true) ;
            }
            if(sharkoBehaviour.immune == false)
            {
                ChangeDirection(new Vector3(2, -2, 0));
                collision.gameObject.GetComponent<SharkoBehaviour>().TakeDamage(1300);
                Debug.Log("Collide");
                Debug.Log(1300);
                sharkoBehaviour.TakeDamage(1300);    
            }
            
            Destroy(gameObject);
            count.Countdown();
        }   
    }
}
