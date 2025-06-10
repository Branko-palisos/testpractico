//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Scripting.APIUpdating;
public class MeteorBehaviour : MonoBehaviour
{
    [SerializeField]
    SharkoBehaviour sharkoBehaviour;
    //string meteor;
    private Vector3 direction;
    [SerializeField]    
    private  EnemiesController enemiesController;
    private int damageAmount = 1000;
    [SerializeField]
     Count count;
     void Start()
     {
        //ChangeDirection(new Vector3(2, -2, 0));
     }
    /*internal void ChangeDirection(Vector3 _newDirection)
    {
        direction = _newDirection;
    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sharko")) // cambiar string por enum
         {
            if (sharkoBehaviour.immune == true) // aser get y set
            {
                sharkoBehaviour.TakeDamage(0) ;
                Destroy(gameObject);
                // Debug.Log("sharko is immune");
                enemiesController.SpawnMeteor(); // aser con evento
            }
            if(sharkoBehaviour.immune == false) // get
            {
               // ChangeDirection(new Vector3(2, -2, 0));
                collision.gameObject.GetComponent<SharkoBehaviour>().TakeDamage(damageAmount); // la variable sharko behaviour no se ocupa
               // Debug.Log("Sharko is not immune");
              //  Debug.Log("Next meteor");      
            }
            count.Countdown(); // aser esto con eventos
        }   
    } 
}