using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int healthCount = 5500;
    [SerializeField]
    public TextMeshProUGUI healthCountTMP;
    [SerializeField]
    public TextMeshProUGUI DamageTMP;
    internal static GameManager gameManager;
    [SerializeField]
    internal float amount = 1300;

    // Start is called before the first frame update
    void Start()
    {
      healthCountTMP.text = 5500.ToString();
    }
    private void UpdateHealthCountTMP()
    {
        healthCountTMP.text = healthCount.ToString();
    }
    internal void UpdateDamageTMP()
    {
        healthCountTMP.text = healthCount.ToString();
        Debug.Log("Damage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  internal void TakeDamage (int _amount) // public check
    {
       
    }
}
