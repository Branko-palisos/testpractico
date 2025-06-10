//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Scripting.APIUpdating;
public class MeteorBehaviour : MonoBehaviour
{

    
    internal delegate void OnMeteorDestroyed();
    internal static event OnMeteorDestroyed onMeteorDestroyed;
    [SerializeField]
    SharkoBehaviour sharkoBehaviour;
    //string meteor;
    private Vector3 direction; 
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
         if (collision.gameObject.CompareTag(EnumManager.Tags.Sharko.ToString())) 
         {  
            if (sharkoBehaviour.GetImmune() == true) 
            {
                sharkoBehaviour.TakeDamage(0) ;
                Destroy(gameObject);
                // Debug.Log("sharko is immune");
                if (onMeteorDestroyed != null)

                {

                    // mando la señal

                    onMeteorDestroyed();

                }

            }
         }
         
            if (sharkoBehaviour.GetImmune() == false)        

            {
               // ChangeDirection(new Vector3(2, -2, 0));
                collision.gameObject.GetComponent<SharkoBehaviour>().TakeDamage(damageAmount); // la variable sharko behaviour no se ocupa
               // Debug.Log("Sharko is not immune");
              //  Debug.Log("Next meteor");      
            }
            count.Countdown(); // aser esto con eventos
            
    } 
 }