using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SharkoBehaviour : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    internal bool immune = false; 
    [SerializeField]
    private int healthCount = 5500;
   [SerializeField]
    GameManager gameManager;
  
    [SerializeField]
  internal  MeteorBehaviour meteorBehaviour;
    internal EnemiesController EnemiesController;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("cambios de jon");
        healthCount = 5500;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("h"))
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("k"))
        {
            transform.position += new Vector3(1 * speed * Time.deltaTime, 0, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
  internal void MakeItInvinsible()
    {
        StartCoroutine(MakeItInvinsibleCR());
    }
    IEnumerator MakeItInvinsibleCR()
    {
        immune = true;
        yield return new WaitForSeconds(10);
        immune = false;
    }
    private void Move()
    { 
        
    }
    internal void TakeDamage(int _amount)
    {
        healthCount -= _amount;
      gameManager.UpdateDamageTMP();
        gameManager.TakeDamage(1300);
        if (immune)
        {
            return; 
        }
       
    }
    void Victory()
    {
        for (int i = 0; i <= 3; i += 1)
        {
            EnemiesController.Meteor[i].SetActive(false);
        }
    }
   
}
