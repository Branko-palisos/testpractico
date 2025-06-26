using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using TMPro;
//using Unity.VisualScripting;
public class SharkoBehaviour : MonoBehaviour
{
    float speed = 5.0f;
    bool immune = false; 
    int healthCount = 5500;
    GameManager gameManager;
    internal  MeteorBehaviour meteorBehaviour;
    internal EnemiesController EnemiesController;
    int silentTime = 10;
    void Start()
    {
        healthCount = 5500;
        gameManager = GameManager.gameManager;
    }
    void Update()
    {
        Move();
        Rotate();
    }
    void Move()
    {
        if (Input.GetKey("h"))
        {
            transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("k"))
        {
            transform.position += new Vector3(1 * speed * Time.deltaTime, 0, 0);
        }
    }
    void Rotate()
    {
        if (Input.GetKey("h"))
        {
            transform.eulerAngles = new Vector3(0, -180, 0);      
        }
        if(Input.GetKey("k"))
        {
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
        yield return new WaitForSeconds(silentTime);
        immune = false;
    }    
    internal void TakeDamage(int _amount)
    {
        if (immune)
        {
            return;
        }
        Debug.Log("Sharko take damage 🙀");
        healthCount -= _amount;
      
        if (healthCount < 0)
        {
            Debug.Log("You lose");
        }
        gameManager.UpdateDamageTMP(healthCount);    
    }
    internal bool GetImmune()
    {
        return immune;
    }
    internal void SetImmune(bool _newValue)
    {
         immune =  _newValue;   
    }
    void Victory()
    {
        for (int i = 0; i <= 3; i += 1)
        {
            EnemiesController.meteors[i].SetActive(false);
        }
    }   
}