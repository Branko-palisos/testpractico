// pasar esto a game manager
//good practises done
//using System.Collections;
//using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;
//using TMPro;
public class Count : MonoBehaviour
{ 
    private int countInc = 5;
    [SerializeField]
    private  GameObject winText;
    private EnemiesController enemiesController;                         
    internal void Countdown()
    {
        countInc -= 1;
        Debug.Log("CountInc="+countInc);
        if (countInc == 0)
        {
           winText.SetActive(true); 
          //  Debug.Log(" VGD 🏀🔥");
        }
    }
}                        