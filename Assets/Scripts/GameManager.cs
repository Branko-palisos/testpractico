//good practices done
//using System.Collections;
//using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    //  [SerializeField]
    //  private int healthCount = 5500;
    [SerializeField]
    private TextMeshProUGUI healthCountTMP;
    [SerializeField]
     TextMeshProUGUI DamageTMP;
    internal static GameManager gameManager;
    [SerializeField]
     float amount = 1300;
    private int countInc = 5;
    [SerializeField]
    private GameObject winText;
    private void Awake()
    {
        if (gameManager == null)
        {
           gameManager = this;
        }
        else
        {
            Destroy(gameObject);    
        }
       DontDestroyOnLoad(this);
    }
   
    void Start()
    {
       healthCountTMP.text = 5500.ToString();
        if (gameManager == null)
        {
            gameManager = this;
        }
    }
    void Countdown()
    {
        countInc -= 1;
        Debug.Log("CountInc=" + countInc);
        if (countInc == 0)
        {
            winText.SetActive(true);
            //  Debug.Log(" VGD 🏀🔥");
        }
    }
    /*private void UpdateHealthCountTMP()
    {
        healthCountTMP.text = healthCount.ToString();
    }*/
    internal void UpdateDamageTMP(int _amount)
    {
        healthCountTMP.text = _amount.ToString();
    }
    internal float GetAmount()
    {
        return amount;
    }
    internal void SetAmount(float _amount)
    {
        amount = _amount;
    }
    internal void SetCountInc (float _amount)
    {
        amount = _amount;
    }
    private void OnEnable()
    {
        MeteorBehaviour.onMeteorDestroyed += Countdown;
    }
    private void OnDisable()
    {
        MeteorBehaviour.onMeteorDestroyed
           -= Countdown;
    }
}