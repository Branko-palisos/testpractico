//good practices done
//using System.Collections;
//using System.Collections.Generic;
using TMPro;
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
    void Start()
    {
       healthCountTMP.text = 5500.ToString();
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
}