using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using Unity.VisualScripting;
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
    void Start()
    {
        healthCount = 5500;
    }
    void Update()
    {
        Move();
    }
    void Move()
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
    internal void TakeDamage(int _amount)
    {
        Debug.Log("Sharko take damage 🙀");
        healthCount -= _amount;
        if (healthCount < 0)
        {
            Debug.Log("You lose");
        }
      gameManager.UpdateDamageTMP(healthCount);
        if (immune)
        {
            return; 
        }  
    }
    void Victory()
    {
        for (int i = 0; i <= 3; i += 1)
        {
            EnemiesController.meteors[i].SetActive(false);
        }
    }   
}