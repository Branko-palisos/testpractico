using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Count : MonoBehaviour
{ 
    public int countInc = 5;
    [SerializeField]
    GameObject TM;
    // Start is called before the first frame update
    void Start()
    {
             
    }
                               
    // Update is called once per frame
    void Update()
    {           
        
    }                    
   internal void Countdown()
    {
        countInc -= 1;
        if (countInc == 0)
        {
            TM.SetActive(true); 
            Debug.Log(" VGD 🏀🔥");
        }
    }
}                        
